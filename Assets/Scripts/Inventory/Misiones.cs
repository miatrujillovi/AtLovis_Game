using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Misiones : MonoBehaviour
{
    public Button claimButton;
    public Text claimText;

    public void Mision1()
    {
        if (MisionsManager.Expansion1 == false)
        {
            GlobalVariableManager.starsInventory += 50;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            MisionsManager.Expansion1 = true;
        }
    }

    public void Mision2()
    {
        if (MisionsManager.Expansion2 == false)
        {
            GlobalVariableManager.starsInventory += 50;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            MisionsManager.Expansion2 = true;
        }
    }

    public void Mision3()
    {
        if (MisionsManager.Expansion3 == false)
        {
            GlobalVariableManager.starsInventory += 50;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            MisionsManager.Expansion3 = true;
        }
    }

    public void Mision4()
    {
        if (MisionsManager.Apariencia1 == false)
        {
            GlobalVariableManager.starsInventory += 50;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            MisionsManager.Apariencia1 = true;
        }
    }

    public void Mision5()
    {
        if (MisionsManager.Apariencia2 == false)
        {
            GlobalVariableManager.starsInventory += 50;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            MisionsManager.Apariencia2 = true;
        }
    }

    public void Mision6()
    {
        if (MisionsManager.Apariencia3 == false)
        {
            GlobalVariableManager.starsInventory += 50;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            MisionsManager.Apariencia3 = true;
        }
    }

    public void Mision7()
    {
        if (MisionsManager.Servicio1 == false)
        {
            GlobalVariableManager.starsInventory += 100;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            MisionsManager.Servicio1 = true;
        }
    }

    public void Mision8()
    {
        if (MisionsManager.OnceClientes == false)
        {
            GlobalVariableManager.starsInventory += 70;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            MisionsManager.OnceClientes = true;
        }
    }

    public void Mision9()
    {
        if (MisionsManager.PrimerPersonaje == false)
        {
            GlobalVariableManager.starsInventory += 30;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            MisionsManager.PrimerPersonaje = true;
        }
    }

    public void Mision10()
    {
        if (MisionsManager.MejoraTalento == false)
        {
            GlobalVariableManager.starsInventory += 50;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            MisionsManager.MejoraTalento = true;
        }
    }

    public void Mision11()
    {
        if (MisionsManager.Nivel2 == false)
        {
            GlobalVariableManager.starsInventory += 20;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            MisionsManager.Nivel2 = true;
        }
    }

    public void Mision12()
    {
        if (MisionsManager.Nivel4 == false)
        {
            GlobalVariableManager.starsInventory += 20;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            MisionsManager.Nivel4 = true;
        }
    }

    public void Mision13()
    {
        if (MisionsManager.Nivel6 == false)
        {
            GlobalVariableManager.starsInventory += 20;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            MisionsManager.Nivel6 = true;
        }
    }

    public void Mision14()
    {
        if (MisionsManager.Nivel8 == false)
        {
            GlobalVariableManager.starsInventory += 20;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            MisionsManager.Nivel8 = true;
        }
    }

    public void Mision15()
    {
        if (MisionsManager.Nivel10 == false)
        {
            GlobalVariableManager.starsInventory += 20;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
            MisionsManager.Nivel10 = true;
        }
    }
}
