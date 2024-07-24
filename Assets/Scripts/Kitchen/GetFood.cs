using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetFood : MonoBehaviour
{
    public GameObject[] foodOnCounter;

    public void TakeFood()
    {
        foodOnCounter[GlobalVariableManager.currentFood].SetActive(false); //Desactiva el Boton de la Comida Correspondiente
        GlobalVariableManager.activeOrder = true; //Cambia la activeOrder a Verdadera
    }
}
