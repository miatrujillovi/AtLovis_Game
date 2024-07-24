using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFood : MonoBehaviour
{
    public GameObject[] foodOnCounter;

    public void TakeFood()
    {
        foodOnCounter[GlobalVariableManager.currentFood].SetActive(false); //Activa el Boton de la Comida Correspondiente
        GlobalVariableManager.activeOrder = true;
    }
}
