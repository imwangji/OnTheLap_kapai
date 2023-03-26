using System.Collections;
using System.Collections.Generic;
using KapaiGame;
using UnityEngine;

namespace KapaiGame
{
    public class PlayerCharacter :Character
    {
        private int _baseHealth = 50;
        private int _baseMana = 20;
        private int _baseSpeed = 5;
        private int initExp = 0;
        private int Level = 1;
        int Mana = 0;
        public List<SkillCard> SkillCards = new List<SkillCard>();

        public PlayerCharacter()
        {
        
        }

        void LevelUp()
        {
            Level++;
            UpdateStatus();
        }
        void UpdateStatus()
        {
            Health = (int)(_baseHealth * Mathf.Pow(1.15f, Level - 1));
            Mana = (int)(_baseHealth * Mathf.Pow(1.05f, Level - 1));
            Speed = (int)(_baseHealth * Mathf.Pow(1.001f, Level - 1));
        }
    }
}

