using UnityEngine;
using System.Collections;

#if UNITY_EDITOR
using UnityEditor;

using Heroes.EditorUtils;
#endif

namespace Heroes.DataModel.Cards.Abilities
{
    public class AbilityData : ScriptableObject
    {
#if UNITY_EDITOR
        [MenuItem("Assets/Create/Ability data")]
        public static void CreateAsset()
        {
            ScriptableObjectUtility.CreateAsset<AbilityData>();
        }
#endif

        // One or more sequential actions, possibly with branching logic.
        public AbilityAction[] actions;
    }
}