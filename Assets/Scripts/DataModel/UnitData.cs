using UnityEngine;

namespace Heroes.DataModel
{
    public abstract class UnitData : ScriptableObject
    {
        [SerializeField]
        protected string unitName;

        [SerializeField]
        protected UnitColor unitColor;

        [SerializeField]
        protected UnitLevelData[] unitLevels;

        [SerializeField]
        protected UnitEvolutionData[] unitEvolutions;

        public virtual Sprite GetUnitIconForEvolution(int evolution)
        {
            if (this.unitEvolutions == null || this.unitEvolutions.Length < 1)
            {
                return null;
            }

            if(evolution < 0 || evolution >= this.unitEvolutions.Length)
            {
                return this.unitEvolutions[0].GetUnitIcon();
            }

            return this.unitEvolutions[evolution].GetUnitIcon();
        }
    }
}