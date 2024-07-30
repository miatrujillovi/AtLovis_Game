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
    public GameObject[] objectsStore;

    void Start()
    {
        loadChar();
        loadStoreExpansions();
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

        manager.SetActive(false);
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

    private void loadChar()
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
    }

    private void loadStoreExpansions()
    {
        if (GlobalVariableManager.storeObjects[0] == false && GlobalVariableManager.storeObjects[1] == true && GlobalVariableManager.expansion1True == true)
        {
            //Normal Expansion
            objectsStore[0].SetActive(false);
            objectsStore[7].SetActive(false);

            //New
            objectsStore[1].SetActive(true);
            objectsStore[8].SetActive(true);
        } 
        else if (GlobalVariableManager.storeObjects[1] == false && GlobalVariableManager.storeObjects[2] == true && GlobalVariableManager.expansion2True == true)
        {
            //Normal Expansion
            objectsStore[0].SetActive(false);
            objectsStore[7].SetActive(false);
            //Expansion 1
            objectsStore[1].SetActive(false);
            objectsStore[8].SetActive(false);

            //New
            objectsStore[2].SetActive(true);
            objectsStore[9].SetActive(true);
        } 
        else if (GlobalVariableManager.storeObjects[2] == false && GlobalVariableManager.storeObjects[3] == true && GlobalVariableManager.expansion3True == true)
        {
            //Normal Expansion
            objectsStore[0].SetActive(false);
            objectsStore[7].SetActive(false);
            //Expansion 1
            objectsStore[1].SetActive(false);
            objectsStore[8].SetActive(false);
            //Expansion 2
            objectsStore[2].SetActive(false);
            objectsStore[9].SetActive(false);

            //New
            objectsStore[3].SetActive(true);
            objectsStore[10].SetActive(true);
        }
        if (GlobalVariableManager.storeObjects[4] == true)
        {
            objectsStore[4].SetActive(true);
        }
        if (GlobalVariableManager.storeObjects[5] == true)
        {
            objectsStore[5].SetActive(true);
        }
        if (GlobalVariableManager.storeObjects[6] == true)
        {
            objectsStore[6].SetActive(true);
        }
    }
}


