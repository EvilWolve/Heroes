using UnityEngine;
using System.Collections;

using Heroes.DataModel.Cards;

namespace Heroes.Battle.Units
{
    public class Fiend : Unit
    {
        protected FiendType fiendType;

        public FiendType GetFiendType()
        {
            return this.fiendType;
        }

        public bool CanFiendUseCard(CardData card)
        {
            if (this.color != card.useConstraints.color)
            {
                return false;
            }

            bool suitable = false;
            for (int i = 0; i < card.useConstraints.fiends.Length; i++)
            {
                if (this.fiendType == card.useConstraints.fiends[i])
                {
                    suitable = true;
                    break;
                }
            }

            return suitable;
        }
    }
}