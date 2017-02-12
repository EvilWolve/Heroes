using UnityEngine;
using System.Collections;

using Heroes.DataModel.Cards;

namespace Heroes.DataModel.Fiends
{
    [System.Serializable]
    public class FiendEvolutionData : UnitEvolutionData
    {
        [SerializeField]
        protected CardData[] unitCards;
    }
}