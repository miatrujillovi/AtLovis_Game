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

    public void TakeOrder()
    {
        if (GlobalVariableManager.activeOrder == false)
        {
            Image activeButtonImage = activeButton.GetComponent<Image>();
            Button activeButtonButton = activeButton.GetComponent<Button>();
            Button kitchenReadyButton = kitchenReady.GetComponent<Button>();
            Text kitchenReadyText = kitchenReady.GetComponentInChildren<Text>();

            foreach (GameObject button in buttons)
            {
                if (button != activeButton)
                {
                    Button btn = button.GetComponent<Button>();
                    btn.enabled = false;
                }
            }
            activeButtonImage.sprite = newFood; // Cambiamos Sprite a la Orden Deseada
            activeButtonButton.enabled = false; // Deshabilita Botón
            kitchenReadyButton.interactable = true; // Habilita Botón de la Cocina
            kitchenReadyText.enabled = true; // Habilita Texto de la Cocina
            kitchenReadyText.text = "Bring Order"; // Activa Texto de la Cocina
            GlobalVariableManager.currentFood = Food; // Cambia el index de currentFood al Correspondiente
            GlobalVariableManager.table = activeButton; //Cambia el GameObject de table al Correspondiente
        }

    }

    public void DeliverOrder()
    {
        if (GlobalVariableManager.activeOrder == true)
        {
            activeButton.SetActive(false);
            disappearClients[tableIndex].SetActive(false);
            foreach (GameObject button in buttons)
            {
                if (button != activeButton)
                {
                    Button btn = button.GetComponent<Button>();
                    if (btn != null)
                    {
                        btn.enabled = true;
                    }
                }
            }
            GlobalVariableManager.activeOrder = false;
        }
    }

}
