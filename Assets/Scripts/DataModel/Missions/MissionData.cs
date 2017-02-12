using UnityEngine;
using System.Collections.Generic;

#if UNITY_EDITOR
using UnityEditor;

using Heroes.EditorUtils;
#endif

namespace Heroes.DataModel.Missions
{
    public class MissionData : ScriptableObject
    {
#if UNITY_EDITOR
        [MenuItem("Assets/Create/Mission data")]
        public static void CreateAsset()
        {
            ScriptableObjectUtility.CreateAsset<MissionData>();
        }
#endif
        
        [SerializeField]
        protected int levelIndex;

        [SerializeField]
        protected List<MissionWaveData> waves;

        [SerializeField]
        protected List<MissionObjective> objectives;

        public int GetLevelIndex()
        {
            return this.levelIndex;
        }

        public MissionWaveData GetWaveAt(int index)
        {
            if(this.waves != null && index >= 0 && index < this.waves.Count)
            {
                return this.waves[index];
            }

            return null;
        }
    }
}