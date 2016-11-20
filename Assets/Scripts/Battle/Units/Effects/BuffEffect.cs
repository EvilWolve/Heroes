using UnityEngine;
using System.Collections;

namespace Heroes.Battle.Units.Effects
{
    public class BuffEffect : StatusEffect
    {
        protected UnitStatType affectedStat;
        protected StatChangeType changeType;

        protected int changeId;
        
        public virtual void Apply(UnitStatController target, float amount, int duration, UnitStatType stat, StatChangeType change)
        {
            this.Apply(target, amount, duration);

            this.affectedStat = stat;
            this.changeType = change;

            this.changeId = this.targetController.ApplyStatusEffect(this.affectedStat, this.changeType, this.effectAmount);
        }

        public override void Cancel()
        {
            this.targetController.CancelStatusEffect(this.affectedStat, this.changeId);

            base.Cancel();
        }
    }
}