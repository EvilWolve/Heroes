using UnityEngine;

namespace Heroes.DataModel
{
    [System.Serializable]
    public class UnitLevelData
    {
        [SerializeField]
        protected float health;
        public float GetHealth()
        {
            return this.health;
        }

        [SerializeField]
        protected float speed;
        public float GetSpeed()
        {
            return this.speed;
        }

        [SerializeField]
        protected float attack;
        public float GetAttack()
        {
            return this.attack;
        }

        [SerializeField]
        protected float defense;
        public float GetDefense()
        {
            return this.defense;
        }

        [SerializeField]
        protected float accuracy;
        public float GetAccuracy()
        {
            return this.accuracy;
        }

        [SerializeField]
        protected float evasion;
        public float GetEvasion()
        {
            return this.evasion;
        }

        [SerializeField]
        protected float criticalHitModifier;
        public float GetCriticalHitModifier()
        {
            return this.criticalHitModifier;
        }

        [SerializeField]
        protected float glancingHitModifier;
        public float GetGlancingHitModifier()
        {
            return this.glancingHitModifier;
        }

        public float GetValueForStat(UnitStatType statType)
        {
            switch (statType)
            {
                case UnitStatType.HEALTH:
                    return this.health;
                case UnitStatType.SPEED:
                    return this.speed;
                case UnitStatType.ATTACK:
                    return this.attack;
                case UnitStatType.DEFENSE:
                    return this.defense;
                case UnitStatType.ACCURACY:
                    return this.accuracy;
                case UnitStatType.EVASION:
                    return this.evasion;
                case UnitStatType.CRITICAL:
                    return this.criticalHitModifier;
                case UnitStatType.GLANCING:
                    return this.glancingHitModifier;
            }

            return 0f;
        }
    }
}