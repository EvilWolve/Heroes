using UnityEngine;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Heroes.DataModel.Player
{
    [System.Serializable]
    public class PlayerData
    {
        #region Singleton
        private static PlayerData _instance;
        public static PlayerData Instance
        {
            get
            {
                if(_instance == null)
                {
                    string savedData = PlayerPrefs.GetString("player_data", "");
                    if(!string.IsNullOrEmpty(savedData))
                    {
                        _instance = JsonConvert.DeserializeObject<PlayerData>(savedData);
                    }
                    else
                    {
                        _instance = new PlayerData();
                    }
                }

                return _instance;
            }
        }
        #endregion

        #region Currencies
        /// <summary>
        /// Currency that was updated, new amount, old amount
        /// </summary>
        public System.Action<Currency, int, int> OnCurrencyAmountChanged;

        public int yellowMites;
        public int blueMites;
        public int gold;
        public int energy;

        public int GetCurrencyAmount(Currency currency)
        {
            switch(currency)
            {
                case Currency.YELLOW_MITES:
                    return this.yellowMites;
                case Currency.BLUE_MITES:
                    return this.blueMites;
                case Currency.GOLD:
                    return this.gold;
                case Currency.ENERGY:
                    return this.energy;
                default:
                    return 0;
            }
        }

        public void AddCurrency(Currency currency, int amount)
        {
            int oldAmount = 0;
            int newAmount = 0;
            switch (currency)
            {
                case Currency.YELLOW_MITES:
                    oldAmount = this.yellowMites;
                    this.yellowMites += amount;
                    newAmount = this.yellowMites;
                    break;
                case Currency.BLUE_MITES:
                    oldAmount = this.blueMites;
                    this.blueMites += amount;
                    newAmount = this.blueMites;
                    break;
                case Currency.GOLD:
                    oldAmount = this.gold;
                    this.gold += amount;
                    newAmount = this.gold;
                    break;
                case Currency.ENERGY:
                    oldAmount = this.energy;
                    this.energy += amount;
                    newAmount = this.energy;
                    break;
            }

            if (this.OnCurrencyAmountChanged != null)
            {
                this.OnCurrencyAmountChanged(currency, newAmount, oldAmount);
            }
        }

        public bool RemoveCurrency(Currency currency, int amount)
        {
            if(this.GetCurrencyAmount(currency) < amount)
            {
                return false;
            }

            this.AddCurrency(currency, -amount);

            return true;
        }
        #endregion

        public List<PlayerFiendData> ownedFiends;
        public List<PlayerFiendData> selectedFiends;

        // TODO: Store data about:
        // Map progress
        // Equipment/spell inventory

        public PlayerData()
        {
            // This is setting the default values for a new save-game!
            this.yellowMites = 0;
            this.blueMites = 0;
            this.gold = 0;
            this.energy = 0;

            this.ownedFiends = new List<PlayerFiendData>();
        }

        public void SavePlayerData()
        {
            string saveString = JsonConvert.SerializeObject(this);

            PlayerPrefs.SetString("player_data", saveString);
        }
    }
}