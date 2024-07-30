using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class GlobalVariableManager : MonoBehaviour
{
    //Variables de Gameplay
    public static int currentFood;
    public static GameObject table;
    public static float Time = 7f;
    public static bool activeOrder;
    public static bool waitingTime;
    public static Button[] activeButtons;
    public static int movementSpeed = 15;

    //Variables de Mejoras de Tienda
    public static bool[] storeObjects = new bool[7];
    public static bool expansion1True;
    public static bool expansion2True;
    public static bool expansion3True;
    public static int[] earnedPropina = new int[] { 5, 10, 15, 20 };
    public static int[] earnedExperiencia = new int[] { 5, 10, 15, 20 };
    public static int[] extraExpDecoraciones = new int[] { 0, 0, 0, 0 };

    //Variables de Personaje
    public static GameObject activeCharacter;
    public static bool[] characters = new bool[9];

    //Variables de Inventario
    public static int clientesAtendidos = 0;
    public static float propinaInventory;
    public static float experienciaInventory;
    public static float starsInventory;
    public static int levelNumber;
    public static int stars;

    // Start is called before the first frame update
    void Start()
    {
        activeOrder = false;
        waitingTime = false;
    }

}
