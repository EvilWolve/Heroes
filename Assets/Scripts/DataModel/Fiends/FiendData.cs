using UnityEngine;
using System.Collections;

#if UNITY_EDITOR
using UnityEditor;

using Heroes.EditorUtils;
#endif

namespace Heroes.DataModel.Fiends
{
    public class FiendData : UnitData
    {
#if UNITY_EDITOR
        [MenuItem("Assets/Create/Fiend data")]
        public static void CreateAsset()
        {
            ScriptableObjectUtility.CreateAsset<FiendData>();
        }
#endif

        public FiendType fiendType;
    }
}
