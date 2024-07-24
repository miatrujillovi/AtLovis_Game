using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariableManager : MonoBehaviour
{
    public static int currentFood;
    public static GameObject table;
    public static float Time;
    public static bool activeOrder;

    // Start is called before the first frame update
    void Start()
    {
        currentFood = 6;
        Time = 7f;
        activeOrder = false;
    }

}
