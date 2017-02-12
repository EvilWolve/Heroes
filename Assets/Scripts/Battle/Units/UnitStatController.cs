using UnityEngine;
using System.Collections.Generic;

using Heroes.DataModel;
using Heroes.Battle.Units.Effects;

namespace Heroes.Battle.Units
{
    public class UnitStatController
    {
        private Unit owner;

        // Health is a special case since we split it into "current health" and "max health".
        // Changes to max health should probably affect the current health?
        private float currentHealth;

        private Dictionary<UnitStatType, UnitStat> unitStats;

        public UnitStatController(Unit owner, UnitLevelData levelData)
        {
            this.owner = owner;

            this.unitStats = new Dictionary<UnitStatType, UnitStat>();

            if(levelData!= null)
            {
                for (int i = 0; i < (int)UnitStatType.LAST; i++)
                {
                    this.unitStats.Add((UnitStatType)i, new UnitStat(levelData.GetValueForStat((UnitStatType)i)));
                }

                this.currentHealth = this.unitStats[UnitStatType.MAX_HEALTH].GetStatValue();
            }
        }

        public void DealDamage(float amount, Unit instigator = null)
        {
            this.currentHealth -= amount;

            if(this.currentHealth <= 0f)
            {
                this.owner.Die(instigator);
            }
        }

        public void RestoreHealth(float amount)
        {
            this.currentHealth = Mathf.Clamp(this.currentHealth + amount, 0f, this.GetStat(UnitStatType.MAX_HEALTH));
        }

        public void StartTurn()
        {
            for (int i = 0; i < (int)UnitStatType.LAST; i++)
            {
                this.unitStats[(UnitStatType)i].UpdateTurnDurations();
            }
        }

        public int ApplyStatusEffect(UnitStatType statType, StatChangeType changeType, float amount, int duration)
        {
            if(this.unitStats != null && this.unitStats.ContainsKey(statType))
            {
                UnitStat stat = this.unitStats[statType];
                return stat.AddStatChange(changeType, amount, duration);
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