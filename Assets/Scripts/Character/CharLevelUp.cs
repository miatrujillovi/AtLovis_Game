using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharLevelUp : MonoBehaviour
{
    public string character;
    public Button levelUpButton;
    public GameObject popUpImage;
    public Text popUpTextWarning;
    public Text confirmTxt;
    public Text levelnumberTxt;

    public Button talentoCarisma;
    public Button talentoVelocidad;
    public Sprite activeTalent;

    private bool[] isLeveled = new bool[9];
    private bool talentCarismaActive;
    private bool talentVelocidadActive;
    private bool carisma;
    private bool velocidad;

    public void SelectCharacter()
    {
        switch (character)
        {
            case "Yuliya":
                GlobalVariableManager.activeCharacter = GlobalVariableManager.charYuliya;
                break;
            case "Aerith":
                GlobalVariableManager.activeCharacter = GlobalVariableManager.charAerith;
                break;
            case "Flandre":
                GlobalVariableManager.activeCharacter = GlobalVariableManager.charFlandre;
                break;
            case "Goldmary":
                GlobalVariableManager.activeCharacter = GlobalVariableManager.charGoldmary;
                break;
            case "Heidr":
                GlobalVariableManager.activeCharacter = GlobalVariableManager.charHeidr;
                break;
            case "Ellen":
                GlobalVariableManager.activeCharacter = GlobalVariableManager.charEllen;
                break;
            case "Kotone":
                GlobalVariableManager.activeCharacter = GlobalVariableManager.charKotone;
                break;
            case "Nezuko":
                GlobalVariableManager.activeCharacter = GlobalVariableManager.charNezuko;
                break;
            case "Shinobu":
                GlobalVariableManager.activeCharacter = GlobalVariableManager.charShinobu;
                break;
            default:
                Debug.LogWarning("Character not recognized: " + character);
                break;
        }
    }

    public void LevelUpPopUp()
    {
        if (isLeveled[9] == true)
        {
            levelUpButton.enabled = false;
        }
        else if (isLeveled[0] == false)
        {
            popUpImage.SetActive(true);
            popUpTextWarning.text = "¿$20?";
            confirmTxt.text = "Subir";
        }
        else if (isLeveled[1] == false)
        {
            popUpImage.SetActive(true);
            popUpTextWarning.text = "¿$40?";
            confirmTxt.text = "Subir";
        }
        else if (isLeveled[2] == false)
        {
            popUpImage.SetActive(true);
            popUpTextWarning.text = "¿$80?";
            confirmTxt.text = "Subir";
        }
        else if (isLeveled[3] == false)
        {
            popUpImage.SetActive(true);
            popUpTextWarning.text = "¿$100?";
            confirmTxt.text = "Subir";
        }
        else if (isLeveled[4] == false)
        {
            popUpImage.SetActive(true);
            popUpTextWarning.text = "¿$120?";
            confirmTxt.text = "Subir";
        }
        else if (isLeveled[5] == false)
        {
            popUpImage.SetActive(true);
            popUpTextWarning.text = "¿$140?";
            confirmTxt.text = "Subir";
        }
        else if (isLeveled[6] == false)
        {
            popUpImage.SetActive(true);
            popUpTextWarning.text = "¿$160?";
            confirmTxt.text = "Subir";
        }
        else if (isLeveled[7] == false)
        {
            popUpImage.SetActive(true);
            popUpTextWarning.text = "¿$180?";
            confirmTxt.text = "Subir";
        }
        else if (isLeveled[8] == false)
        {
            popUpImage.SetActive(true);
            popUpTextWarning.text = "¿$200?";
            confirmTxt.text = "Subir";
        }
        else if (isLeveled[9] == false)
        {
            popUpImage.SetActive(true);
            popUpTextWarning.text = "¿$220?";
            confirmTxt.text = "Subir";
        }
    }

    public void LevelUp()
    {
        if (carisma == false && velocidad == false)
        {
            if (isLeveled[0] == false)
            {
                if (GlobalVariableManager.propinaInventory >= 20)
                {
                    GlobalVariableManager.propinaInventory -= 20;
                    isLeveled[0] = true;
                    levelnumberTxt.text = "1";
                    popUpImage.SetActive(false);
                }
            }
            else if (isLeveled[1] == false)
            {
                if (GlobalVariableManager.propinaInventory >= 40)
                {
                    GlobalVariableManager.propinaInventory -= 40;
                    isLeveled[1] = true;
                    levelnumberTxt.text = "2";
                    popUpImage.SetActive(false);
                }
            }
            else if (isLeveled[2] == false)
            {
                if (GlobalVariableManager.propinaInventory >= 80)
                {
                    GlobalVariableManager.propinaInventory -= 80;
                    isLeveled[2] = true;
                    levelnumberTxt.text = "3";
                    popUpImage.SetActive(false);
                }
            }
            else if (isLeveled[3] == false)
            {
                if (GlobalVariableManager.propinaInventory >= 100)
                {
                    GlobalVariableManager.propinaInventory -= 100;
                    isLeveled[3] = true;
                    levelnumberTxt.text = "4";
                    popUpImage.SetActive(false);
                }
            }
            else if (isLeveled[4] == false)
            {
                if (GlobalVariableManager.propinaInventory >= 120)
                {
                    GlobalVariableManager.propinaInventory -= 120;
                    isLeveled[4] = true;
                    levelnumberTxt.text = "5";
                    popUpImage.SetActive(false);
                }
            }
            else if (isLeveled[5] == false)
            {
                if (GlobalVariableManager.propinaInventory >= 140)
                {
                    GlobalVariableManager.propinaInventory -= 140;
                    isLeveled[5] = true;
                    levelnumberTxt.text = "6";
                    popUpImage.SetActive(false);
                }
            }
            else if (isLeveled[6] == false)
            {
                if (GlobalVariableManager.propinaInventory >= 160)
                {
                    GlobalVariableManager.propinaInventory -= 160;
                    isLeveled[6] = true;
                    levelnumberTxt.text = "7";
                    popUpImage.SetActive(false);
                }
            }
            else if (isLeveled[7] == false)
            {
                if (GlobalVariableManager.propinaInventory >= 180)
                {
                    GlobalVariableManager.propinaInventory -= 180;
                    isLeveled[7] = true;
                    levelnumberTxt.text = "8";
                    popUpImage.SetActive(false);
                }
            }
            else if (isLeveled[8] == false)
            {
                if (GlobalVariableManager.propinaInventory >= 200)
                {
                    GlobalVariableManager.propinaInventory -= 200;
                    isLeveled[8] = true;
                    levelnumberTxt.text = "9";
                    popUpImage.SetActive(false);
                }
            }
            else if (isLeveled[9] == false)
            {
                if (GlobalVariableManager.propinaInventory >= 220)
                {
                    GlobalVariableManager.propinaInventory -= 220;
                    isLeveled[9] = true;
                    levelnumberTxt.text = "10";
                    popUpImage.SetActive(false);
                }
            }
        }
    }

    public void TalentoCarismaPopUp()
    {
        if (talentCarismaActive == false)
        {
            popUpImage.SetActive(true);
            popUpTextWarning.text = "¿$300?";
            confirmTxt.text = "Activar";
            carisma = true;
        }
    }

    public void TalentoVelocidadPopUp()
    {
        if (talentVelocidadActive == false)
        {
            popUpImage.SetActive(true);
            popUpTextWarning.text = "¿$300?";
            confirmTxt.text = "Activar";
            velocidad = true;
        }
    }

    public void ActivarCarisma()
    {
        if (carisma == true)
        {
            if (GlobalVariableManager.propinaInventory >= 300)
            {
                GlobalVariableManager.propinaInventory -= 300;
                Image CarismaButton = talentoCarisma.GetComponent<Image>();
                CarismaButton.sprite = activeTalent;
                talentoCarisma.enabled = false;
                popUpImage.SetActive(false);
                carisma = false;
            }
        }
    }
    public void ActivarVelocidad()
    {
        if (velocidad == true)
        {
            if (GlobalVariableManager.propinaInventory >= 300)
            {
                GlobalVariableManager.propinaInventory -= 300;
                Image VelocidadButton = talentoVelocidad.GetComponent<Image>();
                VelocidadButton.sprite = activeTalent;
                talentoVelocidad.enabled = false;
                popUpImage.SetActive(false);
                velocidad = false;
            }
        }
    }
}
