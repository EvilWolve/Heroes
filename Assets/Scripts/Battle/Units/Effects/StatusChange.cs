using UnityEngine;
using System.Collections;

namespace Heroes.Battle.Units.Effects
{
    public class StatusChange
    {
        public UnitStatType affectedStat;
        public StatChangeType changeType;

        public float amount;
    }
}