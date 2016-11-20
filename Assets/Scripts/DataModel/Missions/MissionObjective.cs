using UnityEngine;
using System.Collections;

namespace Heroes.DataModel.Missions
{
    // Subclass this to get different types of win conditions
    public class MissionObjective
    {
        [SerializeField]
        protected MissionObjectiveType _objectiveType;
        public MissionObjectiveType objectiveType
        {
            get
            {
                return this.objectiveType;
            }
        }

        [SerializeField]
        protected MissionReward _objectiveReward;
        public MissionReward objectiveReward
        {
            get
            {
                return this._objectiveReward;
            }
        }
    }
}