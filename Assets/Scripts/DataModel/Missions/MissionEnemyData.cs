using UnityEngine;
using System.Collections;

namespace Heroes.DataModel.Missions
{
    [SerializeField]
    public class MissionEnemyData
    {
        public SlugType type;
        public int level;

        public int position;
    }
}