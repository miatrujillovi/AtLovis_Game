using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariableManager : MonoBehaviour
{
    public static int currentFood;
    public static int tableNumber;

    // Start is called before the first frame update
    void Start()
    {
        currentFood = 6;
        tableNumber = 20;
    }

}
