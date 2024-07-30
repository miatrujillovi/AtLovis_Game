using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static LootTable;

public class LootTableDisplay : MonoBehaviour
{
    [SerializeField] private LootTable lootTable;
    [SerializeField] private GameObject lootItemPrefab;
    [SerializeField] private Transform lootItemsParent;
    [SerializeField] private int itemsToDisplay = 10;
    [SerializeField] private Vector2 startOffset = new Vector2(10, -10);
    [SerializeField] private Vector2 itemSpacing = new Vector2(100, 100);

    public void DisplayRandomItems()
    {
        if (lootTable == null || lootItemPrefab == null || lootItemsParent == null)
        {
            Debug.LogError("Una referencia no está asignada en el Inspector.");
            return;
        }

        if (GlobalVariableManager.starsInventory >= 100)
        {
            GlobalVariableManager.starsInventory -= 100;

            foreach (Transform child in lootItemsParent)
            {
                Destroy(child.gameObject);
            }

            for (int i = 0; i < itemsToDisplay; i++)
            {
                RewardItem randomItem = lootTable.GetRandomItem();
                randomItem.IsObtained = true;

                GameObject lootItemUI = Instantiate(lootItemPrefab, lootItemsParent);

                Image itemImage = lootItemUI.GetComponentInChildren<Image>();
                if (itemImage != null)
                {
                    //Variable de Mision General
                    if (MisionsManager.PrimerPersonaje == false)
                    {
                        MisionsManager.PrimerPersonaje = true;
                    }

                    Debug.Log(randomItem.IsObtained);
                    itemImage.sprite = randomItem.sprite;
                }
                else
                {
                    Debug.LogError("El prefab LootItemUI no tiene un componente Image dentro del Panel.");
                }

                RectTransform rectTransform = lootItemUI.GetComponent<RectTransform>();
                float xPos = startOffset.x + (i % 5) * itemSpacing.x;
                float yPos = startOffset.y - (i / 5) * itemSpacing.y;
                rectTransform.anchoredPosition = new Vector2(xPos, yPos);
            }
        }
        else
        {
            Debug.Log("No tienes suficientes estrellas para generar loot.");
        }
    }
}