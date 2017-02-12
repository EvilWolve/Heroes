using UnityEngine;
using System.Collections;

namespace Heroes.DataModel.Missions
{
    // Subclass this to get different types of win/lose conditions
    [System.Serializable]
    public abstract class MissionObjective
    {
        [SerializeField]
        protected bool isMandatory;

        [SerializeField]
        protected MissionReward _objectiveReward;
        public MissionReward objectiveReward
        {
            get
            {
                return this._objectiveReward;
            }
        }

        // Some objectives will probably want to subscribe to events to track progress?
        public abstract void Init();

        public abstract bool HasCompletedObjective();
    }
}