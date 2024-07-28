using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    //Variables de Mejoras de Tienda
    public static GameObject activeExpansion;
    public static GameObject activeDecoracion;
    public static GameObject activeClients;

    public static int[] earnedPropina;
    public static int[] earnedExperiencia;
    public static int[] extraExpDecoraciones;

    //Variables de Personaje
    public static GameObject activeCharacter;

    //Variables de Inventario
    public static int clientesAtendidos;
    public static float propinaInventory;
    public static float experienciaInventory;
    public static float starsInventory = 100;
    public static int levelNumber;
    public static int stars;

    // Start is called before the first frame update
    void Start()
    {
        Time = 7f;
        activeOrder = false;
        waitingTime = false;
        activeButtons = GameObject.FindObjectsOfType<Button>();
    }

}
