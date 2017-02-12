using UnityEngine;
using System.Collections;

#if UNITY_EDITOR
using UnityEditor;

using Heroes.EditorUtils;
#endif

public class EconomyData : ScriptableObject
{
#if UNITY_EDITOR
    [MenuItem("Assets/Create/Economy data")]
    public static void CreateAsset()
    {
        ScriptableObjectUtility.CreateAsset<EconomyData>();
    }
#endif

    [System.Serializable]
    public class CardUpgradeCost
    {
        public Currency currencyType;
        public int amount;
    }

    [System.Serializable]
    public class CardLevelCost
    {
        public int level;
        public CardUpgradeCost[] costs;
    }

    [System.Serializable]
    public class CardRarityCostProgression
    {
        public CardRarity rarity;
        public CardLevelCost[] levelCosts;
    }

    public CardRarityCostProgression[] cardRarityUpgradeCosts;
}
