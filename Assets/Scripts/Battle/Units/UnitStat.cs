using UnityEngine;
using System.Collections.Generic;

namespace Heroes.Battle.Units
{
    public class UnitStat
    {
        private int uniqueIdCounter = 0;

        private bool hasChanged = false;

        private List<UnitStatChange> changes;

        private float baseValue;
        private float currentValue;

        public UnitStat(float value)
        {
            this.baseValue = value;
        }

        public int AddStatChange(StatChangeType type, float amount, int duration)
        {
            int id = uniqueIdCounter;
            uniqueIdCounter++;

            UnitStatChange change = new UnitStatChange(id);
            change.changeType = type;
            change.changeAmount = amount;
            change.turnsRemaining = duration;

            this.changes.Add(change);

            this.hasChanged = true;

            return id;
        }

        public void RemoveStatChange(int id)
        {
            for (int i = this.changes.Count; i >= 0; i--)
            {
                if (this.changes[i].GetId() == id)
                {
                    this.changes.RemoveAt(i);
                }
            }

            this.hasChanged = true;
        }

        public float GetStatValue()
        {
            if (this.hasChanged)
            {
                this.currentValue = this.RecalculateStat();
            }

            return this.currentValue;
        }

        public void UpdateTurnDurations()
        {
            UnitStatChange change = null;
            bool cancelledSomething = false;

            for (int i = this.changes.Count - 1; i >= 0; i--)
            {
                change = this.changes[i];
                change.turnsRemaining--;

                if(change.turnsRemaining <= 0)
                {
                    this.changes.RemoveAt(i);
                    cancelledSomething = true;
                }
            }

            this.hasChanged |= cancelledSomething;
        }

        private float RecalculateStat()
        {
            float result = this.baseValue;
            UnitStatChange change = null;

            for (int i = 0; i < this.changes.Count; i++)
            {
                change = this.changes[i];
                switch (change.changeType)
                {
                    case StatChangeType.ADD:
                        result += change.changeAmount;
                        break;
                    case StatChangeType.SUBTRACT:
                        result -= change.changeAmount;
                        break;
                    case StatChangeType.MULTIPLY:
                        result *= change.changeAmount;
                        break;
                    case StatChangeType.DIVIDE:
                        result /= change.changeAmount;
                        break;
                }
            }

            return result;
        }
    }
}