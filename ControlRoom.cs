﻿using BlackPearlShip.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackPearlShip
{
    /// <summary>
    /// Main Control Room in the ship.
    /// Here we listen to the radio and process all the information.
    /// </summary>
    public class ControlRoom : IRadioListeners
    {
        private RadioReceiver Radio { get; set; }
        private MealAlgo MealAlgo { get; set; }
        private WeaponAlgo WeaponAlgo { get; set; }
        private DrinkingAlgo DrinkingAlgo { get; set; }

        public ControlRoom(RadioReceiver radio)
        {
            this.Radio = radio;
            this.Radio.StartListen(this);

            this.MealAlgo = new MealAlgo(this);
            this.WeaponAlgo = new WeaponAlgo(this);
            this.DrinkingAlgo = new DrinkingAlgo(this);
        }

        /// <summary>
        /// Receive data from the radio
        /// (Implement IRadioListeners)
        /// </summary>
        public void Receive(string data)
        {
            // TODO: do some logic
            throw new NotImplementedException();
        }

        #region input from algorithms

        /// <summary>
        /// Receive from DrinkingAlgo how much the crew should drink
        /// </summary>
        public void SetAmountToDrink(int amount)
        {

        }

        /// <summary>
        /// Receive from MealAlgo type of food crew should eat
        /// </summary>
        public void SetTypeOfFoodToEat(FoodType foodType)
        {

        }

        /// <summary>
        /// Receive from MealAlgo amount of food crew should eat
        /// </summary>
        public void SetAmountOfFoodToEat(int amount)
        {

        }

        /// <summary>
        /// Receive from WeaponAlgo canon number to fire
        /// </summary>
        public void SetCanonToFire(int canonNumber)
        {

        }

        /// <summary>
        /// Receive from WeaponAlgo did we hit or miss the enemy ship
        /// </summary>
        public void SetHitOrMissEnemyShip(bool isHit)
        {

        }

        #endregion input from algorithms
    }
}
