using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    private GameObject expansion;
    private GameObject decoraciones;
    private GameObject character;
    private GameObject clients;

    void Start()
    {
        GlobalVariableManager.activeDecoracion = decoraciones;
        GlobalVariableManager.activeExpansion = expansion;
        GlobalVariableManager.activeCharacter = character;
        GlobalVariableManager.activeClients = clients;
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while (true)
        {
            expansion.SetActive(true);
            decoraciones.SetActive(true);
            character.SetActive(true);
            yield return new WaitForSeconds(120);

            expansion.SetActive(false);
            decoraciones.SetActive(false);
            character.SetActive(false);
        }
    }
}
