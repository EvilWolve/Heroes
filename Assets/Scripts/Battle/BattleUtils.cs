using UnityEngine;

namespace Heroes.Battle
{
    public static class BattleUtils
    {
        public static AttackHitResult GetHitResult(float attackerAccuracy, float defenderDodge)
        {
            // TODO: Add calculations
            return AttackHitResult.NORMAL;
        }

        public static float CalculateStrengthWeakness(UnitColor attackerColor, UnitColor defenderColor)
        {
            // TODO: Add calculations
            return 1.0f;
        }
    }
}