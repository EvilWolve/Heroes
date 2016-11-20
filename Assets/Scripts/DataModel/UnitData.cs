using UnityEngine;

namespace Heroes.DataModel
{
    public abstract class UnitData : ScriptableObject
    {
        [SerializeField]
        protected string unitName;

        [SerializeField]
        protected UnitColor unitColor;

        [SerializeField]
        protected UnitLevelData[] unitLevels;

        [SerializeField]
        protected UnitEvolutionData[] unitEvolutions;

        public virtual Sprite GetUnitIconForEvolution(int evolution)
        {
            if (this.unitEvolutions == null || this.unitEvolutions.Length < 1)
            {
                return null;
            }

            if(evolution < 0 || evolution >= this.unitEvolutions.Length)
            {
                return this.unitEvolutions[0].GetUnitIcon();
            }

            return this.unitEvolutions[evolution].GetUnitIcon();
        }

        public UnitLevelData GetLevelData(int level)
        {
            if (this.unitLevels == null || level < 0 || level >= this.unitLevels.Length)
            {
                return null;
            }

            return this.unitLevels[level];
        }

        public float GetStatForLevel(int level, UnitStatType stat)
        {
            UnitLevelData levelData = this.GetLevelData(level);
            if(levelData != null)
            {
                return levelData.GetValueForStat(stat);
            }

            return 0f;
        }

        public float GetStatDifferenceBetweenLevels(int startLevel, int endLevel, UnitStatType stat)
        {
            UnitLevelData startLevelData = this.GetLevelData(startLevel);
            UnitLevelData endLevelData = this.GetLevelData(endLevel);

            if(startLevelData == null)
            {
                if(endLevelData != null)
                {
                    return endLevelData.GetValueForStat(stat);
                }
                else
                {
                    return 0f;
                }
            }
            else if(endLevelData == null)
            {
                return -startLevelData.GetValueForStat(stat);
            }
            else
            {
                return endLevelData.GetValueForStat(stat) - startLevelData.GetValueForStat(stat);
            }
        }
    }
}