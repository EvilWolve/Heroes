using UnityEngine;
using System.Collections;

namespace Heroes.Battle.Units
{
    public class Unit : MonoBehaviour
    {
        protected UnitStatController statController;

        public void Init()
        {


            this.Setup();
        }

        protected virtual void Setup()
        {

        }

        public float GetStat(UnitStatType statType)
        {
            if(this.statController == null)
            {
                return 0f;
            }

            return this.statController.GetStat(statType);
        }
    }
}