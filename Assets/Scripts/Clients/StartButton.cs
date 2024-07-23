using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public int currentFood;
    public GameObject activeButton;
    public GameObject newButton;
    public Text kitchenReady;
    static bool activeOrder;

    public void TakeOrder()
    {
        if (activeOrder == false){
            activeButton.SetActive(false);
            newButton.SetActive(true);
            
            activeOrder = true;
        } else {
            activeButton.SetActive(true);
            activeOrder = false;
        }
    }

}
