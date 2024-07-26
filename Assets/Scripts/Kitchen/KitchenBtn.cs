using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KitchenBtn : MonoBehaviour
{
    public GameObject[] foodOnCounter;
    public GameObject kitchenBtn;


    public void RecibeOrder()
    {
        StartCoroutine(CookingTime(GlobalVariableManager.Time));
    }

    IEnumerator CookingTime(float _time)
    {
        
        Text kitchenBtnText = kitchenBtn.GetComponentInChildren<Text>();
        Button kitchenReadyButton = kitchenBtn.GetComponent<Button>();

        kitchenReadyButton.interactable = false; //Deshabilita Interaccion con Boton de Cocina mientras la corutina trabaja
        kitchenBtnText.text = "Cooking..."; // Activa Texto de la Cocina

        yield return new WaitForSeconds(_time);

        Debug.Log("Se detiene la corrutina??");
        foodOnCounter[GlobalVariableManager.currentFood].SetActive(true); //Activa el Boton de la Comida Correspondiente
        kitchenBtnText.enabled = false;

    }

}
