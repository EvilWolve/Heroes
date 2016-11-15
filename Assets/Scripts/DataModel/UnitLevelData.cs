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
        protected float damage;
        public float GetDamage()
        {
            return this.damage;
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
        protected float dodge;
        public float GetDodge()
        {
            return this.dodge;
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
    }
}