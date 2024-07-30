using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreUpgrades : MonoBehaviour
{
    public Button[] upgrade;
    public Text[] changeText;

    private bool[] clientela;
    private bool[] calidad;

    public void Start()
    {
        clientela = new bool[] { false, false, false, false };
        calidad = new bool[] { false, false, false, false };
    }

    public void Expansion1()
    {
        if (GlobalVariableManager.propinaInventory >= 200)
        {
            GlobalVariableManager.propinaInventory -= 200;
            upgrade[0].enabled = false;
            changeText[0].text = "Comprado";
            GlobalVariableManager.expansion1True = true;
            GlobalVariableManager.storeObjects[0] = false;
            GlobalVariableManager.storeObjects[1] = true;
            //Variable de Mision General
            MisionsManager.Expansion1 = true;
        }
    }

    public void Expansion2()
    {
        if (GlobalVariableManager.storeObjects[1] == true)
        {
            if (GlobalVariableManager.propinaInventory >= 200)
            {
                GlobalVariableManager.propinaInventory -= 200;
                upgrade[1].enabled = false;
                changeText[1].text = "Comprado";
                GlobalVariableManager.expansion1True = false;
                GlobalVariableManager.expansion2True = true;
                GlobalVariableManager.storeObjects[1] = false;
                GlobalVariableManager.storeObjects[2] = true;
                //Variable de Mision General
                MisionsManager.Expansion2 = true;
            }
        }
    }

    public void Expansion3()
    {
        if (GlobalVariableManager.storeObjects[2] == true)
        {
            if (GlobalVariableManager.propinaInventory >= 300)
            {
                GlobalVariableManager.propinaInventory -= 300;
                upgrade[2].enabled = false;
                changeText[2].text = "Comprado";
                GlobalVariableManager.expansion2True = false;
                GlobalVariableManager.expansion3True = true;
                GlobalVariableManager.storeObjects[2] = false;
                GlobalVariableManager.storeObjects[3] = true;
                //Variable de Mision General
                MisionsManager.Expansion3 = true;
            }
        }
    }

    public void Decoraciones1()
    {
        if (GlobalVariableManager.propinaInventory >= 100)
        {
            GlobalVariableManager.propinaInventory -= 100;
            upgrade[3].enabled = false;
            changeText[3].text = "Comprado";
            GlobalVariableManager.storeObjects[4] = true;
            GlobalVariableManager.movementSpeed = 25;
            //Variable de Mision General
            MisionsManager.Apariencia1 = true;
        }
    }

    public void Decoraciones2()
    {
        if (GlobalVariableManager.propinaInventory >= 200)
        {
            GlobalVariableManager.propinaInventory -= 200;
            upgrade[4].enabled = false;
            changeText[4].text = "Comprado";
            GlobalVariableManager.storeObjects[5] = true;
            GlobalVariableManager.Time = 4;
            //Variable de Mision General
            MisionsManager.Apariencia2 = true;
        }
    }

    public void Decoraciones3()
    {
        if (GlobalVariableManager.propinaInventory >= 300)
        {
            GlobalVariableManager.propinaInventory -= 300;
            upgrade[5].enabled = false;
            changeText[5].text = "Comprado";
            GlobalVariableManager.storeObjects[6] = true;
            GlobalVariableManager.extraExpDecoraciones = new int[] { 5, 10, 15, 20 };
            //Variable de Mision General
            MisionsManager.Apariencia3 = true;
        }
    }

    public void Clientela1()
    {
        if (clientela[0] == false)
        {
            if (GlobalVariableManager.propinaInventory >= 100)
            {
                GlobalVariableManager.propinaInventory -= 100;
                changeText[6].text = "Nivel 1";
                clientela[0] = true;
                GlobalVariableManager.earnedPropina = new int[] { 15, 20, 25, 30 };
            }
        }
    }

    public void Clientela2()
    {
        if (clientela[1] == false)
        {
            if (GlobalVariableManager.propinaInventory >= 150)
            {
                GlobalVariableManager.propinaInventory -= 150;
                changeText[6].text = "Nivel 2";
                clientela[1] = true;
                GlobalVariableManager.earnedPropina = new int[] { 25, 30, 35, 40 };
            }
        }
    }
    public void Clientela3()
    {
        if (clientela[2] == false)
        {
            if (GlobalVariableManager.propinaInventory >= 200)
            {
                GlobalVariableManager.propinaInventory -= 200;
                changeText[6].text = "Nivel 3";
                clientela[2] = true;
                GlobalVariableManager.earnedPropina = new int[] { 35, 40, 45, 50 };
            }
        }
    }

    public void Clientela4()
    {
        if (clientela[3] == false)
        {
            if (GlobalVariableManager.propinaInventory >= 250)
            {
                GlobalVariableManager.propinaInventory -= 250;
                changeText[6].text = "Nivel 4";
                clientela[3] = true;
                GlobalVariableManager.earnedPropina = new int[] { 45, 50, 55, 60 };
            }
        }
    }

    public void Clientela5()
    {
        if (clientela[4] == false)
        {
            if (GlobalVariableManager.propinaInventory >= 300)
            {
                GlobalVariableManager.propinaInventory -= 300;
                changeText[6].text = "Nivel 5";
                upgrade[6].enabled = false;
                clientela[4] = true;
                GlobalVariableManager.earnedPropina = new int[] { 55, 60, 65, 70 };
            }
        }
    }

    public void Calidad1()
    {
        if (calidad[0] == false)
        {
            if (GlobalVariableManager.propinaInventory >= 100)
            {
                GlobalVariableManager.propinaInventory -= 100;
                changeText[7].text = "Nivel 1";
                calidad[0] = true;
                GlobalVariableManager.earnedExperiencia = new int[] { 15, 20, 25, 30 };
            }
        }
    }

    public void Calidad2()
    {
        if (calidad[1] == false)
        {
            if (GlobalVariableManager.propinaInventory >= 150)
            {
                GlobalVariableManager.propinaInventory -= 150;
                changeText[7].text = "Nivel 2";
                calidad[1] = true;
                GlobalVariableManager.earnedExperiencia = new int[] { 25, 30, 35, 40 };
            }
        }
    }

    public void Calidad3()
    {
        if (calidad[2] == false)
        {
            if (GlobalVariableManager.propinaInventory >= 200)
            {
                GlobalVariableManager.propinaInventory -= 200;
                changeText[7].text = "Nivel 3";
                calidad[2] = true;
                GlobalVariableManager.earnedExperiencia = new int[] { 35, 40, 45, 50 };
            }
        }
    }

    public void Calidad4()
    {
        if (calidad[3] == false)
        {
            if (GlobalVariableManager.propinaInventory >= 250)
            {
                GlobalVariableManager.propinaInventory -= 250;
                changeText[7].text = "Nivel 4";
                calidad[3] = true;
                GlobalVariableManager.earnedExperiencia = new int[] { 45, 50, 55, 60 };
            }
        }
    }

    public void Calidad5()
    {
        if (calidad[4] == false)
        {
            if (GlobalVariableManager.propinaInventory >= 300)
            {
                GlobalVariableManager.propinaInventory -= 300;
                changeText[7].text = "Nivel 5";
                upgrade[7].enabled = false;
                calidad[4] = true;
                GlobalVariableManager.earnedExperiencia = new int[] { 55, 60, 65, 70 };
            }
        }
    }
}
