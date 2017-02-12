using UnityEngine;
using System.Collections;

namespace Heroes.Battle.Units.Effects
{
    public class BuffEffect : StatusEffect
    {
        protected StatusChange change;

        protected int changeId;
        
        public virtual void Apply(UnitStatController target, StatusChange change, int duration)
        {
            this.Apply(target, change.amount, duration);

            this.change = change;

            this.changeId = this.targetController.ApplyStatusEffect(this.change.affectedStat, this.change.changeType, this.effectAmount, this.effectDuration);
        }

        public override void Cancel()
        {
            this.targetController.CancelStatusEffect(this.change.affectedStat, this.changeId);

            base.Cancel();
        }
    }
}