using UnityEngine;
using System.Collections;

namespace Heroes.Battle.Units
{
    public class Unit : MonoBehaviour
    {
        protected UnitStatController statController;

        protected UnitColor color;

        public void Init()
        {
            // What else do we want to do here?

            this.Setup();
        }

        protected virtual void Setup()
        {
            // TODO: Fetch correct level data
            //      -> For Fiends: From player inventory
            //      -> For Slugs: From level config
        }

        public UnitColor GetColor()
        {
            return this.color;
        }

        public float GetStat(UnitStatType statType)
        {
            if(this.statController == null)
            {
                return 0f;
            }

            return this.statController.GetStat(statType);
        }

        public void Die(Unit instigator = null)
        {

        }
    }
}