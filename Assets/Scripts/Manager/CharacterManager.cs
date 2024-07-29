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

    /*public void FlandreSelect()
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
    }*/
}
