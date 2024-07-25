using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariableManager : MonoBehaviour
{
    //Variables de Gameplay
    public static int currentFood;
    public static GameObject table;
    public static float Time;
    public static bool activeOrder;

    //Variables de Mejoras de Tienda
    public static GameObject activeExpansion;
    public static GameObject activeDecoracion;
    public static GameObject activeClients;

    //Variables de Personaje
    public static GameObject activeCharacter;

    // Start is called before the first frame update
    void Start()
    {
        Time = 7f;
        activeOrder = false;
    }

}
