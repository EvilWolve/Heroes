using UnityEngine;
using System.Collections;

namespace Heroes.Battle.Units.Effects
{
    public class StatusEffect
    {
        protected float effectAmount;
        protected int effectDuration;

        protected UnitStatController targetController;

        public virtual void Apply(UnitStatController target, float amount, int duration)
        {
            this.targetController = target;

            this.effectAmount = amount;
            this.effectDuration = duration;
        }

        public virtual void Cancel()
        {

        }

        public virtual void PreTurnExecute()
        {

        }

        public virtual void PostTurnExecute()
        {

        }
    }
}