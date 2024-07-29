using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static LootTable;

public class CharacterManager : MonoBehaviour
{
    public GameObject[] charMenu;
    [SerializeField] private LootTable lootTable;
    [SerializeField] private string[] charName;

    public void AerithSelect()
    {
        RewardItem character = lootTable._items.Find(item => item.itemName == charName[0]);
        if (character != null)
        {
            if (character.IsObtained)
            {
                Debug.Log(charName[0] + " has been obtained.");
                charMenu[0].SetActive(false);
                charMenu[1].SetActive(true);
            }
            else
            {
                Debug.Log(charName[0] + " has not been obtained.");
            }
        }
        else
        {
            Debug.LogError("Character " + charName[0] + " with the specified weight and sprite not found in LootTable.");
        }
    }

    public void FlandreSelect()
    {
        RewardItem character = lootTable._items.Find(item => item.itemName == charName[1]);
        if (character != null)
        {
            if (character.IsObtained)
            {
                Debug.Log(charName[1] + " has been obtained.");
                charMenu[0].SetActive(false);
                charMenu[2].SetActive(true);
            }
            else
            {
                Debug.Log(charName[1] + " has not been obtained.");
            }
        }
        else
        {
            Debug.LogError("Character " + charName[1] + " with the specified weight and sprite not found in LootTable.");
        }
    }

    public void GoldmarySelect()
    {
        RewardItem character = lootTable._items.Find(item => item.itemName == charName[2]);
        if (character != null)
        {
            if (character.IsObtained)
            {
                Debug.Log(charName[2] + " has been obtained.");
                charMenu[0].SetActive(false);
                charMenu[3].SetActive(true);
            }
            else
            {
                Debug.Log(charName[2] + " has not been obtained.");
            }
        }
        else
        {
            Debug.LogError("Character " + charName[2] + " with the specified weight and sprite not found in LootTable.");
        }
    }

    public void HeidrSelect()
    {
        RewardItem character = lootTable._items.Find(item => item.itemName == charName[3]);
        if (character != null)
        {
            if (character.IsObtained)
            {
                Debug.Log(charName[3] + " has been obtained.");
                charMenu[0].SetActive(false);
                charMenu[4].SetActive(true);
            }
            else
            {
                Debug.Log(charName[3] + " has not been obtained.");
            }
        }
        else
        {
            Debug.LogError("Character " + charName[3] + " with the specified weight and sprite not found in LootTable.");
        }
    }

    public void EllenSelect()
    {
        RewardItem character = lootTable._items.Find(item => item.itemName == charName[4]);
        if (character != null)
        {
            if (character.IsObtained)
            {
                Debug.Log(charName[4] + " has been obtained.");
                charMenu[0].SetActive(false);
                charMenu[5].SetActive(true);
            }
            else
            {
                Debug.Log(charName[4] + " has not been obtained.");
            }
        }
        else
        {
            Debug.LogError("Character " + charName[4] + " with the specified weight and sprite not found in LootTable.");
        }
    }

    public void KotoneSelect()
    {
        RewardItem character = lootTable._items.Find(item => item.itemName == charName[5]);
        if (character != null)
        {
            if (character.IsObtained)
            {
                Debug.Log(charName[5] + " has been obtained.");
                charMenu[0].SetActive(false);
                charMenu[6].SetActive(true);
            }
            else
            {
                Debug.Log(charName[5] + " has not been obtained.");
            }
        }
        else
        {
            Debug.LogError("Character " + charName[5] + " with the specified weight and sprite not found in LootTable.");
        }
    }

    public void NezukoSelect()
    {
        RewardItem character = lootTable._items.Find(item => item.itemName == charName[6]);
        if (character != null)
        {
            if (character.IsObtained)
            {
                Debug.Log(charName[6] + " has been obtained.");
                charMenu[0].SetActive(false);
                charMenu[7].SetActive(true);
            }
            else
            {
                Debug.Log(charName[6] + " has not been obtained.");
            }
        }
        else
        {
            Debug.LogError("Character " + charName[6] + " with the specified weight and sprite not found in LootTable.");
        }
    }

    public void ShinobuSelect()
    {
        RewardItem character = lootTable._items.Find(item => item.itemName == charName[7]);
        if (character != null)
        {
            if (character.IsObtained)
            {
                Debug.Log(charName[7] + " has been obtained.");
                charMenu[0].SetActive(false);
                charMenu[8].SetActive(true);
            }
            else
            {
                Debug.Log(charName[7] + " has not been obtained.");
            }
        }
        else
        {
            Debug.LogError("Character " + charName[7] + " with the specified weight and sprite not found in LootTable.");
        }
    }
}
