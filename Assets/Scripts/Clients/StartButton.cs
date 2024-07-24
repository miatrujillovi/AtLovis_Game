using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    //Variables Publicas
    public int Food;
    public int Table;
    public GameObject[] buttons;
    public GameObject activeButton;
    public GameObject kitchenReady;
    public Sprite newFood;

    public void TakeOrder()
    {
        if (activeButton != null && kitchenReady != null && newFood != null)
        {
            Image activeButtonImage = activeButton.GetComponent<Image>();
            Button activeButtonButton = activeButton.GetComponent<Button>();
            Button kitchenReadyButton = kitchenReady.GetComponent<Button>();
            Text kitchenReadyText = kitchenReady.GetComponentInChildren<Text>();

            if (activeButtonImage != null && activeButtonButton != null && kitchenReadyButton != null && kitchenReadyText != null)
            {
                foreach (GameObject button in buttons)
                {
                    if (button != activeButton)
                    {
                        Button btn = button.GetComponent<Button>();
                        if (btn != null)
                        {
                            btn.enabled = false;
                        }
                    }
                }
                activeButtonImage.sprite = newFood; // Cambiamos Sprite a la Orden Deseada
                activeButtonButton.enabled = false; // Deshabilita Botón
                kitchenReadyButton.interactable = true; // Habilita Botón de la Cocina
                kitchenReadyText.text = "Bring Order"; // Activa Texto de la Cocina
                GlobalVariableManager.currentFood = Food; // Cambia el index de currentFood al Correspondiente
                GlobalVariableManager.tableNumber = Table; //Cambia el index de tableNumber al Correspondiente
            }
            else
            {
                Debug.LogError("Uno o más componentes son nulos.");
            }
        }
        else
        {
            Debug.LogError("Una o más referencias de GameObject son nulas.");
        }

    }

}
