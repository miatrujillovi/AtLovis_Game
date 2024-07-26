using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class GetFood : MonoBehaviour
{
    public GameObject[] foodOnCounter;

    public void TakeFood()
    {
        foodOnCounter[GlobalVariableManager.currentFood].SetActive(false); //Desactiva el Boton de la Comida Correspondiente
        GlobalVariableManager.activeOrder = true; //Cambia la activeOrder a Verdadera
        GlobalVariableManager.waitingTime = true; //Cambia waitingTime a Verdadera
    }
}
