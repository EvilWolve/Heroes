using UnityEngine;

using Heroes.DataModel.Abilities;

namespace Heroes.DataModel
{
    [System.Serializable]
    public class UnitEvolutionData
    {
        [SerializeField]
        protected Sprite unitIcon;

        [SerializeField]
        protected string unitPrefabPath;

        [SerializeField]
        protected AbilityData[] unitAbilities;

        protected GameObject cachedUnitPrefab;

        public Sprite GetUnitIcon()
        {
            return this.unitIcon;
        }

        public GameObject GetUnitPrefab()
        {
            if (string.IsNullOrEmpty(this.unitPrefabPath))
            {
                return null;
            }

            if (this.cachedUnitPrefab == null)
            {
                this.cachedUnitPrefab = Resources.Load(this.unitPrefabPath) as GameObject;
            }

            return this.cachedUnitPrefab;
        }
    }
}