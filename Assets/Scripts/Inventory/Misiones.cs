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
        if (MisionsManager.Expansion1 == true)
        {
            GlobalVariableManager.starsInventory += 50;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
        }
    }

    public void Mision2()
    {
        if (MisionsManager.Expansion2 == true)
        {
            GlobalVariableManager.starsInventory += 50;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
        }
    }

    public void Mision3()
    {
        if (MisionsManager.Expansion3 == true)
        {
            GlobalVariableManager.starsInventory += 50;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
        }
    }

    public void Mision4()
    {
        if (MisionsManager.Apariencia1 == true)
        {
            GlobalVariableManager.starsInventory += 50;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
        }
    }

    public void Mision5()
    {
        if (MisionsManager.Apariencia2 == true)
        {
            GlobalVariableManager.starsInventory += 50;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
        }
    }

    public void Mision6()
    {
        if (MisionsManager.Apariencia3 == true)
        {
            GlobalVariableManager.starsInventory += 50;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
        }
    }

    public void Mision7()
    {
        if (MisionsManager.Servicio1 == true)
        {
            GlobalVariableManager.starsInventory += 100;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
        }
    }

    public void Mision8()
    {
        if (MisionsManager.OnceClientes == true)
        {
            GlobalVariableManager.starsInventory += 70;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
        }
    }

    public void Mision9()
    {
        if (MisionsManager.PrimerPersonaje == true)
        {
            GlobalVariableManager.starsInventory += 30;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
        }
    }

    public void Mision10()
    {
        if (MisionsManager.MejoraTalento == true)
        {
            GlobalVariableManager.starsInventory += 50;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
        }
    }

    public void Mision11()
    {
        if (MisionsManager.Nivel2 == true)
        {
            GlobalVariableManager.starsInventory += 20;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
        }
    }

    public void Mision12()
    {
        if (MisionsManager.Nivel4 == true)
        {
            GlobalVariableManager.starsInventory += 20;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
        }
    }

    public void Mision13()
    {
        if (MisionsManager.Nivel6 == true)
        {
            GlobalVariableManager.starsInventory += 20;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
        }
    }

    public void Mision14()
    {
        if (MisionsManager.Nivel8 == true)
        {
            GlobalVariableManager.starsInventory += 20;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
        }
    }

    public void Mision15()
    {
        if (MisionsManager.Nivel10 == true)
        {
            GlobalVariableManager.starsInventory += 20;
            claimButton.enabled = false;
            claimText.text = "Reclamado";
        }
    }
}
