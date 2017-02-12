using UnityEngine;
using System.Collections;

#if UNITY_EDITOR
using UnityEditor;

using Heroes.EditorUtils;
#endif

namespace Heroes.DataModel.Cards.Equipments
{

    public class EquipmentData : ScriptableObject
    {
#if UNITY_EDITOR
        [MenuItem("Assets/Create/Equipment data")]
        public static void CreateAsset()
        {
            ScriptableObjectUtility.CreateAsset<EquipmentData>();
        }
#endif

    }
}
