using UnityEngine;
using System.Collections;

using Heroes.Battle.Units.Effects;

namespace Heroes.DataModel.Cards.Abilities
{
    [System.Serializable]
    public class AbilityAction
    {
        [SerializeField]
        protected Targeting targeting;

        [SerializeField]
        protected AbilityActionLevel[] levels;

        /*
        * How is direct damage handled? As a part of status effects, affecting health?
        *   -> Health is treated separately.
        * How are effects handled if an ability has multiple targets with different effects?
        * For example, we target one enemy and then two more at random?
        * Or, we hit and damage one enemy and then heal ourselves for the damage dealt, or we shield a random ally?
        * Might this be a combination of multiple abilities in a sequence? So, first fire one ability with this specific targeting,
        * and then other abilities afterwards with different effects and targeting?
        */
    }
}