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
    public static float Time;
    public static bool activeOrder;
    public static bool waitingTime;
    public static Button[] activeButtons;
    public static int movementSpeed;

    //Variables de Mejoras de Tienda
    public static GameObject normalExpansion;
    public static GameObject expansion1;
    public static GameObject expansion2;
    public static GameObject expansion3;
    public static GameObject decoraciones1;
    public static GameObject decoraciones2;
    public static GameObject decoraciones3;
    public static GameObject activeClientsNormal;
    public static GameObject activeClientsExpansion1;
    public static GameObject activeClientsExpansion2;
    public static GameObject activeClientsExpansion3;

    public static int[] earnedPropina;
    public static int[] earnedExperiencia;
    public static int[] extraExpDecoraciones;

    //Variables de Personaje
    public static GameObject activeCharacter;
    public static bool[] characters;

    //Variables de Inventario
    public static int clientesAtendidos;
    public static float propinaInventory;
    public static float experienciaInventory;
    public static float starsInventory;
    public static int levelNumber;
    public static int stars;

    // Start is called before the first frame update
    void Start()
    {
        Time = 7f;
        activeOrder = false;
        waitingTime = false;
        //activeButtons = GameObject.FindObjectsOfType<Button>();
        movementSpeed = 15;
        extraExpDecoraciones = new int[] { 0, 0, 0, 0 };
        earnedPropina = new int[] { 5, 10, 15, 20 };
        earnedExperiencia = new int[] { 5, 10, 15, 20 };
        characters = new bool[8];
        characters[0] = true;
    }

}
