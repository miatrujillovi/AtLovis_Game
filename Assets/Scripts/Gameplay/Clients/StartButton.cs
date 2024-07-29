using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    //Variables Publicas
    public int Food;
    public GameObject[] buttons;
    public GameObject[] disappearClients;
    public int tableIndex;
    public GameObject activeButton;
    public GameObject kitchenReady;
    public Sprite newFood;
    public Sprite oldFood;

    public void TakeOrder()
    {
        Debug.Log("TakeOrder called");

        if (GlobalVariableManager.activeOrder == false && GlobalVariableManager.waitingTime == false)
        {
            Image activeButtonImage = activeButton.GetComponent<Image>();
            Button kitchenReadyButton = kitchenReady.GetComponent<Button>();
            Text kitchenReadyText = kitchenReady.GetComponentInChildren<Text>();
            Button activeButtonButton = activeButton.GetComponentInChildren<Button>();

            foreach (GameObject button in buttons)
            {
                Button btn = button.GetComponent<Button>();
                btn.enabled = false;
            }
            activeButtonButton.enabled = true;
            GlobalVariableManager.waitingTime = true;
            activeButtonImage.sprite = newFood; // Cambiamos Sprite a la Orden Deseada
            kitchenReadyButton.interactable = true; // Habilita Interaccion con Boton de Cocina
            kitchenReadyText.enabled = true; // Habilita Texto de la Cocina
            kitchenReadyText.text = "Bring Order"; // Activa Texto de la Cocina
            GlobalVariableManager.currentFood = Food; // Cambia el index de currentFood al Correspondiente
            GlobalVariableManager.table = activeButton; //Cambia el GameObject de table al Correspondiente
        }
        else
        {
            Debug.Log("GlobalVariableManager.activeOrder is true");
        }

    }

    public void DeliverOrder()
    {
        Debug.Log("DeliverOrder called");

        if (GlobalVariableManager.activeOrder == true && GlobalVariableManager.waitingTime == true)
        {

            Image activeButtonImage = activeButton.GetComponent<Image>();

            activeButton.SetActive(false);
            disappearClients[tableIndex].SetActive(false);
            foreach (GameObject button in buttons)
            {
                Button btn = button.GetComponent<Button>();
                btn.enabled = true;
            }
            GlobalVariableManager.activeOrder = false; // Cambia activeOrder a false
            GlobalVariableManager.waitingTime = false; //Cambia waitingTime a false
            GlobalVariableManager.clientesAtendidos++; //Aumenta la Variable de Clientes Atendidos
            activeButtonImage.sprite = oldFood; // Cambiamos Sprite al Original
        } 
        else
        {
            Debug.Log("GlobalVariableManager.activeOrder is false");
        }
    }

}
