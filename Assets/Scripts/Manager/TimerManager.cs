using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public GameObject manager;
    public GameObject canvas;
    public Text propinaTxt;
    public Text experienciaTxt;
    private GameObject character;

    void Start()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        GlobalVariableManager.activeCharacter = character;
        character.SetActive(true);
        yield return new WaitForSeconds(120);

        //Variable de Mision General
        if (MisionsManager.Servicio1 == false)
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
        if (GlobalVariableManager.clientesAtendidos <= 3)
        {
            GlobalVariableManager.propinaInventory += GlobalVariableManager.earnedPropina[0];
            propinaTxt.text = $"Propina Ganada: {GlobalVariableManager.earnedPropina[0]}";
        } 
        else if (GlobalVariableManager.clientesAtendidos <= 6)
        {
            GlobalVariableManager.propinaInventory += GlobalVariableManager.earnedPropina[1];
            propinaTxt.text = $"Propina Ganada: {GlobalVariableManager.earnedPropina[1]}";
        }
        else if (GlobalVariableManager.clientesAtendidos <= 10)
        {
            GlobalVariableManager.propinaInventory += GlobalVariableManager.earnedPropina[2];
            propinaTxt.text = $"Propina Ganada: {GlobalVariableManager.earnedPropina[2]}";
        } 
        else if (GlobalVariableManager.clientesAtendidos <= 16)
        {
            //Variable de Mision General
            if (MisionsManager.OnceClientes == false)
            {
                MisionsManager.OnceClientes = true;
            }
            GlobalVariableManager.propinaInventory += GlobalVariableManager.earnedPropina[3];
            propinaTxt.text = $"Propina Ganada: {GlobalVariableManager.earnedPropina[3]}";
        }
    }

    private void CalcularExperiencia()
    {
        if (GlobalVariableManager.clientesAtendidos <= 3)
        {
            GlobalVariableManager.experienciaInventory += GlobalVariableManager.earnedExperiencia[0] + GlobalVariableManager.extraExpDecoraciones[0];
            experienciaTxt.text = $"Experiencia Ganada: {GlobalVariableManager.earnedExperiencia[0]}";
        } 
        else if (GlobalVariableManager.clientesAtendidos <= 6)
        {
            GlobalVariableManager.experienciaInventory += GlobalVariableManager.earnedExperiencia[1] + GlobalVariableManager.extraExpDecoraciones[1];
            experienciaTxt.text = $"Experiencia Ganada: {GlobalVariableManager.earnedExperiencia[1]}";
        } 
        else if (GlobalVariableManager.clientesAtendidos <= 10)
        {
            GlobalVariableManager.experienciaInventory += GlobalVariableManager.earnedExperiencia[2] + GlobalVariableManager.extraExpDecoraciones[2];
            experienciaTxt.text = $"Experiencia Ganada: {GlobalVariableManager.earnedExperiencia[2]}";
        } 
        else if (GlobalVariableManager.clientesAtendidos <= 16)
        {
            GlobalVariableManager.experienciaInventory += GlobalVariableManager.earnedExperiencia[3] + GlobalVariableManager.extraExpDecoraciones[3];
            experienciaTxt.text = $"Experiencia Ganada: {GlobalVariableManager.earnedExperiencia[3]}";
        }
    }
}
