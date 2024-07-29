using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "LootTable", menuName = "Loot Table")]
public class LootTable : ScriptableObject
{
    [System.Serializable]
    public class RewardItem
    {
        public string itemName;
        public float weight;
        public Sprite sprite;
        [System.NonSerialized] private bool isObtained;

        public bool IsObtained
        {
            get { return isObtained; }
            set { isObtained = value; }
        }
    }

    [SerializeField] public List<RewardItem> _items;
    [System.NonSerialized] private bool isInitialized = false;

    private float _totalWeight;

    private void Initialize()
    {
        if (!isInitialized)
        {
            _totalWeight = _items.Sum(item => item.weight);
            isInitialized = true;
        }
    }

    public RewardItem GetRandomItem()
    {
        // Make sure it is initalized
        Initialize();

        // Roll our dice with _totalWeight faces
        float diceRoll = Random.Range(0f, _totalWeight);

        // Cycle through our items
        foreach (var item in _items)
        {
            // If item.weight is greater (or equal) than our diceRoll, we take that item and return
            if (item.weight >= diceRoll)
            {
                // Return here, so that the cycle doesn't keep running
                return item;
            }

            // If we didn't return, we substract the weight to our diceRoll and cycle to the next item
            diceRoll -= item.weight;
        }

        // As long as everything works we'll never reach this point, but better be notified if this happens!
        throw new System.Exception("Reward generation failed!");
    }
}
