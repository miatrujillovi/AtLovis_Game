using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static LootTable;

public class LootTableDisplay : MonoBehaviour
{
    [SerializeField] private LootTable lootTable;
    [SerializeField] private GameObject lootItemPrefab; // Prefab del panel que contiene una imagen
    [SerializeField] private Transform lootItemsParent;
    [SerializeField] private int itemsToDisplay = 10;
    [SerializeField] private Vector2 startOffset = new Vector2(10, -10); // Desplazamiento inicial
    [SerializeField] private Vector2 itemSpacing = new Vector2(100, 100); // Espaciado entre elementos

    public void DisplayRandomItems()
    {
        // Verificar que las referencias estén asignadas
        if (lootTable == null)
        {
            Debug.LogError("LootTable no está asignado en el Inspector.");
            return;
        }
        if (lootItemPrefab == null)
        {
            Debug.LogError("LootItemPrefab no está asignado en el Inspector.");
            return;
        }
        if (lootItemsParent == null)
        {
            Debug.LogError("LootItemsParent no está asignado en el Inspector.");
            return;
        }

        if (GlobalVariableManager.starsInventory >= 100)
        {
            // Reducir estrellas
            GlobalVariableManager.starsInventory -= 100;

            // Limpiar los elementos anteriores si existen
            foreach (Transform child in lootItemsParent)
            {
                Destroy(child.gameObject);
            }

            // Mostrar los nuevos elementos
            for (int i = 0; i < itemsToDisplay; i++)
            {
                RewardItem randomItem = lootTable.GetRandomItem();
                GameObject lootItemUI = Instantiate(lootItemPrefab, lootItemsParent);

                // Buscar la imagen dentro del panel del prefab
                Image itemImage = lootItemUI.GetComponentInChildren<Image>();
                if (itemImage != null)
                {
                    Debug.Log("Asignando sprite: " + randomItem.sprite.name);
                    itemImage.sprite = randomItem.sprite;
                }
                else
                {
                    Debug.LogError("El prefab LootItemUI no tiene un componente Image dentro del Panel.");
                }

                // Ajustar la posición del lootItemUI
                RectTransform rectTransform = lootItemUI.GetComponent<RectTransform>();
                float xPos = startOffset.x + (i % 5) * itemSpacing.x; // Posición en X
                float yPos = startOffset.y - (i / 5) * itemSpacing.y; // Posición en Y
                rectTransform.anchoredPosition = new Vector2(xPos, yPos);
            }
        }
        else
        {
            Debug.Log("No tienes suficientes estrellas para generar loot.");
        }
    }
}