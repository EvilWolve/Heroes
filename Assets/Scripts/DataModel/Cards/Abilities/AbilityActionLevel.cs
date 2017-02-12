using UnityEngine;
using System.Collections;

using Heroes.Battle.Units.Effects;

namespace Heroes.DataModel.Cards.Abilities
{
    [System.Serializable]
    public class AbilityActionLevel
    {
        [SerializeField]
        protected StatusChange[] statusChanges;
    }
}