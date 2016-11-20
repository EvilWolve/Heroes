using UnityEngine;
using System.Collections.Generic;

using Heroes.DataModel;
using Heroes.Battle.Units.Effects;

namespace Heroes.Battle.Units
{
    public class UnitStatController
    {
        private Dictionary<UnitStatType, UnitStat> unitStats;

        public UnitStatController(UnitLevelData levelData)
        {
            this.unitStats = new Dictionary<UnitStatType, UnitStat>();

            if(levelData!= null)
            {
                // TODO: Maybe wrap this in a loop over all enum values?
                this.unitStats.Add(UnitStatType.HEALTH, new UnitStat(levelData.GetValueForStat(UnitStatType.HEALTH)));
                this.unitStats.Add(UnitStatType.SPEED, new UnitStat(levelData.GetValueForStat(UnitStatType.SPEED)));
                this.unitStats.Add(UnitStatType.ATTACK, new UnitStat(levelData.GetValueForStat(UnitStatType.ATTACK)));
                this.unitStats.Add(UnitStatType.DEFENSE, new UnitStat(levelData.GetValueForStat(UnitStatType.DEFENSE)));
                this.unitStats.Add(UnitStatType.ACCURACY, new UnitStat(levelData.GetValueForStat(UnitStatType.ACCURACY)));
                this.unitStats.Add(UnitStatType.EVASION, new UnitStat(levelData.GetValueForStat(UnitStatType.EVASION)));
                this.unitStats.Add(UnitStatType.CRITICAL, new UnitStat(levelData.GetValueForStat(UnitStatType.CRITICAL)));
                this.unitStats.Add(UnitStatType.GLANCING, new UnitStat(levelData.GetValueForStat(UnitStatType.GLANCING)));
            }
        }

        public int ApplyStatusEffect(UnitStatType statType, StatChangeType changeType, float amount)
        {
            if(this.unitStats != null && this.unitStats.ContainsKey(statType))
            {
                UnitStat stat = this.unitStats[statType];
                return stat.AddStatChange(changeType, amount);
            }

            return -1;
        }

        public void CancelStatusEffect(UnitStatType statType, int id)
        {
            if (this.unitStats != null && this.unitStats.ContainsKey(statType))
            {
                this.unitStats[statType].RemoveStatChange(id);
            }
        }

        public float GetStat(UnitStatType statType)
        {
            if (this.unitStats != null && this.unitStats.ContainsKey(statType))
            {
                return this.unitStats[statType].GetStatValue();
            }
            else
            {
                return 0f;
            }
        }
    }
}