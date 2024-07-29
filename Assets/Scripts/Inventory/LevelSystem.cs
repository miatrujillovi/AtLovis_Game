using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSystem : MonoBehaviour
{
    public Button claimButton;
    public Text claimText;

    public void Nivel1()
    {
        if (GlobalVariableManager.experienciaInventory == 30)
        {
            GlobalVariableManager.levelNumber = 1;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.starsInventory += 10;
            GlobalVariableManager.propinaInventory += 50;
        }
    }

    public void Nivel2()
    {
        if (GlobalVariableManager.experienciaInventory >= 90)
        {
            GlobalVariableManager.levelNumber = 2;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.propinaInventory += 60;
        }
    }

    public void Nivel3(){
        if (GlobalVariableManager.experienciaInventory >= 180)
        {
            GlobalVariableManager.levelNumber = 3;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.propinaInventory += 70;
        }
    }

    public void Nivel4()
    {
        if (GlobalVariableManager.experienciaInventory >= 300)
        {
            GlobalVariableManager.levelNumber = 4;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.propinaInventory += 80;
        }
    }
    public void Nivel5()
    {
        if (GlobalVariableManager.experienciaInventory >= 460)
        {
            GlobalVariableManager.levelNumber = 5;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.starsInventory += 100;
            GlobalVariableManager.propinaInventory += 100;
        }
    }
    public void Nivel6()
    {
        if (GlobalVariableManager.experienciaInventory >= 650)
        {
            GlobalVariableManager.levelNumber = 6;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.propinaInventory += 110;
        }
    }

    public void Nivel7()
    {
        if (GlobalVariableManager.experienciaInventory >= 860)
        {
            GlobalVariableManager.levelNumber = 7;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.propinaInventory += 120;
        }
    }
    public void Nivel8()
    {
        if (GlobalVariableManager.experienciaInventory >= 1100)
        {
            GlobalVariableManager.levelNumber = 8;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.propinaInventory += 130;
        }
    }
    public void Nivel9()
    {
        if (GlobalVariableManager.experienciaInventory >= 1370)
        {
            GlobalVariableManager.levelNumber = 9;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.propinaInventory += 140;
        }
    }
    public void Nivel10()
    {
        if (GlobalVariableManager.experienciaInventory >= 1670)
        {
            GlobalVariableManager.levelNumber = 10;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.starsInventory += 100;
            GlobalVariableManager.propinaInventory += 150;
        }
    }
    public void Nivel11()
    {
        if (GlobalVariableManager.experienciaInventory >= 2000)
        {
            GlobalVariableManager.levelNumber = 11;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.propinaInventory += 160;
        }
    }
    public void Nivel12()
    {
        if (GlobalVariableManager.experienciaInventory >= 2360)
        {
            GlobalVariableManager.levelNumber = 12;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.propinaInventory += 170;
        }
    }
    public void Nivel13()
    {
        if (GlobalVariableManager.experienciaInventory >= 2750)
        {
            GlobalVariableManager.levelNumber = 13;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.propinaInventory += 180;
        }
    }
    public void Nivel14()
    {
        if (GlobalVariableManager.experienciaInventory >= 3170)
        {
            GlobalVariableManager.levelNumber = 14;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.propinaInventory += 190;
        }
    }
    public void Nivel15()
    {
        if (GlobalVariableManager.experienciaInventory >= 3630)
        {
            GlobalVariableManager.levelNumber = 15;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.starsInventory += 100;
            GlobalVariableManager.propinaInventory += 200;
        }
    }
    public void Nivel16()
    {
        if (GlobalVariableManager.experienciaInventory >= 4120)
        {
            GlobalVariableManager.levelNumber = 16;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.propinaInventory += 210;
        }
    }
    public void Nivel17()
    {
        if (GlobalVariableManager.experienciaInventory >= 4630)
        {
            GlobalVariableManager.levelNumber = 17;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.propinaInventory += 220;
        }
    }
    public void Nivel18()
    {
        if (GlobalVariableManager.experienciaInventory >= 5170)
        {
            GlobalVariableManager.levelNumber = 18;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.propinaInventory += 230;
        }
    }
    public void Nivel19()
    {
        if (GlobalVariableManager.experienciaInventory >= 5740)
        {
            GlobalVariableManager.levelNumber = 19;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.propinaInventory += 240;
        }
    }
    public void Nivel20()
    {
        if (GlobalVariableManager.experienciaInventory >= 6340)
        {
            GlobalVariableManager.levelNumber = 20;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            GlobalVariableManager.starsInventory += 100;
            GlobalVariableManager.propinaInventory += 250;
        }
    }
}
