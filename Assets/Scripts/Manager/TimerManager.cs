using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public GameObject manager;
    public GameObject canvas;
    public Text propinaTxt;
    public Text experienciaTxt;
    public GameObject[] character;

    void Start()
    {
        if (GlobalVariableManager.characters[0] == true)
        {
            character[0].SetActive(true);
        } 
        else if (GlobalVariableManager.characters[1] == true)
        {
            character[1].SetActive(true);
        }
        else if (GlobalVariableManager.characters[2] == true)
        {
            character[2].SetActive(true);
        }
        else if (GlobalVariableManager.characters[3] == true)
        {
            character[3].SetActive(true);
        }
        else if (GlobalVariableManager.characters[4] == true)
        {
            character[4].SetActive(true);
        }
        else if (GlobalVariableManager.characters[5] == true)
        {
            character[5].SetActive(true);
        }
        else if (GlobalVariableManager.characters[6] == true)
        {
            character[6].SetActive(true);
        }
        else if (GlobalVariableManager.characters[7] == true)
        {
            character[7].SetActive(true);
        }
        else if (GlobalVariableManager.characters[8] == true)
        {
            character[8].SetActive(true);
        }

        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        Debug.Log("Corrutina Countdown iniciada");

        Debug.Log("Esperando 120 segundos...");
        yield return new WaitForSeconds(120);

        Debug.Log("10 segundos han pasado");
        // Variable de Misión General
        if (!MisionsManager.Servicio1)
        {
            MisionsManager.Servicio1 = true;
        }

        // manager.SetActive(false);
        canvas.SetActive(true);

        CalcularPropina();
        CalcularExperiencia();
    }

    private void CalcularPropina()
    {
        Debug.Log("Calculando propina...");


        if (GlobalVariableManager.clientesAtendidos == 0)
        {
            propinaTxt.text = "No Ganaste Propinas";
        }
        else if (GlobalVariableManager.clientesAtendidos >= 1 && GlobalVariableManager.clientesAtendidos <= 3)
        {
            GlobalVariableManager.propinaInventory += GlobalVariableManager.earnedPropina[0];
            propinaTxt.text = $"Propina Ganada: {GlobalVariableManager.earnedPropina[0]}";
        } 
        else if (GlobalVariableManager.clientesAtendidos >= 4 && GlobalVariableManager.clientesAtendidos <= 6)
        {
            GlobalVariableManager.propinaInventory += GlobalVariableManager.earnedPropina[1];
            propinaTxt.text = $"Propina Ganada: {GlobalVariableManager.earnedPropina[1]}";
        } 
        else if (GlobalVariableManager.clientesAtendidos >= 7 && GlobalVariableManager.clientesAtendidos <= 10)
        {
            GlobalVariableManager.propinaInventory += GlobalVariableManager.earnedPropina[2];
            propinaTxt.text = $"Propina Ganada: {GlobalVariableManager.earnedPropina[2]}";
        } 
        else if (GlobalVariableManager.clientesAtendidos >= 11)
        {
            if (!MisionsManager.OnceClientes)
            {
                MisionsManager.OnceClientes = true;
            }
            GlobalVariableManager.propinaInventory += GlobalVariableManager.earnedPropina[3];
            propinaTxt.text = $"Propina Ganada: {GlobalVariableManager.earnedPropina[3]}";
        }
    }

    private void CalcularExperiencia()
    {
        Debug.Log("Calculando experiencia...");

        if (GlobalVariableManager.clientesAtendidos == 0)
        {
            experienciaTxt.text = "No Ganaste Experiencia";
        } 
        else if (GlobalVariableManager.clientesAtendidos >= 1 && GlobalVariableManager.clientesAtendidos <= 3)
        {
            GlobalVariableManager.experienciaInventory += GlobalVariableManager.earnedExperiencia[0] + GlobalVariableManager.extraExpDecoraciones[0];
            experienciaTxt.text = $"Experiencia Ganada: {GlobalVariableManager.earnedExperiencia[0]}";
        } 
        else if (GlobalVariableManager.clientesAtendidos >= 4 && GlobalVariableManager.clientesAtendidos <= 6)
        {
            GlobalVariableManager.experienciaInventory += GlobalVariableManager.earnedExperiencia[1] + GlobalVariableManager.extraExpDecoraciones[1];
            experienciaTxt.text = $"Experiencia Ganada: {GlobalVariableManager.earnedExperiencia[1]}";
        } 
        else if (GlobalVariableManager.clientesAtendidos >= 7 && GlobalVariableManager.clientesAtendidos <= 10)
        {
            GlobalVariableManager.experienciaInventory += GlobalVariableManager.earnedExperiencia[2] + GlobalVariableManager.extraExpDecoraciones[2];
            experienciaTxt.text = $"Experiencia Ganada: {GlobalVariableManager.earnedExperiencia[2]}";
        } 
        else if (GlobalVariableManager.clientesAtendidos >= 11)
        {
            GlobalVariableManager.experienciaInventory += GlobalVariableManager.earnedExperiencia[3] + GlobalVariableManager.extraExpDecoraciones[3];
            experienciaTxt.text = $"Experiencia Ganada: {GlobalVariableManager.earnedExperiencia[3]}";
        }
    }
}


