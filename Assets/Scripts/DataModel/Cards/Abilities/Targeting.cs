using UnityEngine;
using System.Collections;

namespace Heroes.DataModel.Cards.Abilities
{
    [System.Serializable]
    public class Targeting
    {
        public enum TargetType
        {
            NONE = -1,
            SINGLE = 0,
            ALL = 1
        }

        public enum TargetingRestrictionType
        {
            NONE = -1,
            SELF = 0,
            ALLY = 1,
            ENEMY = 2
        }

        public enum TargetingRangeType
        {
            NONE = -1,
            SINGLE = 0,
            NEIGHBOURS = 1,
            LEFT_NEIGHBOUR = 2,
            RIGHT_NEIGHBOUR = 3,
        }

        public TargetType targetType;

        public TargetingRestrictionType restrictionType;

        public TargetingRangeType rangeType;

        public int targetAmount;

        public bool random;
    }
}