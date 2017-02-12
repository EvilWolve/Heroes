using UnityEngine;
using System.Collections;

namespace Heroes.Battle.Units
{
    public class UnitStatChange
    {
        public StatChangeType changeType;
        public float changeAmount;

        public int turnsRemaining;

        private int changeId;

        public UnitStatChange(int id)
        {
            this.changeId = id;
        }

        public int GetId()
        {
            return this.changeId;
        }
    }
}