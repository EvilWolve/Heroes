using UnityEngine;
using System.Collections.Generic;

namespace Heroes.DataModel.Missions
{
    public class MissionWaveData
    {
        [SerializeField]
        protected List<MissionEnemyData> waveEnemies = new List<MissionEnemyData>();
        
        [SerializeField]
        protected List<MissionReward> waveRewards = new List<MissionReward>();

        public List<MissionReward> GetWaveRewards()
        {
            List<MissionReward> rewards = new List<MissionReward>();

            if(this.waveRewards != null)
            {
                for (int i = 0; i < this.waveRewards.Count; i++)
                {
                    if (Random.Range(0f, 1f) < this.waveRewards[i].rewardChance)
                    {
                        rewards.Add(this.waveRewards[i]);
                    }
                }
            }
            
            return rewards;
        }
    }
}