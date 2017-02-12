using UnityEngine;
using System.Collections;

namespace Heroes.DataModel.Cards
{
    [System.Serializable]
    public class CardUseConstraints
    {
        public UnitColor color;
        public FiendType[] fiends;
    }
}