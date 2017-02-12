using UnityEngine;
using System.Collections;

#if UNITY_EDITOR
using UnityEditor;

using Heroes.EditorUtils;
#endif

using Heroes.DataModel.Cards.Abilities;

namespace Heroes.DataModel.Cards
{
    public class CardData : ScriptableObject
    {
#if UNITY_EDITOR
        [MenuItem("Assets/Create/Card data")]
        public static void CreateAsset()
        {
            ScriptableObjectUtility.CreateAsset<CardData>();
        }
#endif

        public CardRarity rarity;

        public CardUseConstraints useConstraints;

        public int energyCost;

        public AbilityData ability;
    }
}