using UnityEngine;
using System.Collections;

#if UNITY_EDITOR
using UnityEditor;

using Heroes.EditorUtils;
#endif

namespace Heroes.DataModel.Slugs
{
    public class SlugData : UnitData
    {
#if UNITY_EDITOR
        [MenuItem("Assets/Create/Slug data")]
        public static void CreateAsset()
        {
            ScriptableObjectUtility.CreateAsset<SlugData>();
        }
#endif
    }
}