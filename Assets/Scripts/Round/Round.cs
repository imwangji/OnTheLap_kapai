using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Manager;
using UnityEngine;

namespace KapaiGame
{
    public class Round
    {
        private List<Card> _hand;
        private List<Buff.Buff> _playerBuffs;
        private List<Monster> _currentMonsters;

        public event Action<Round> OnRoundCreate;
        public Round()
        {
            _hand = new List<Card>();
            _playerBuffs = new List<Buff.Buff>();
            _currentMonsters = GameManager.Instance.CurrentFloor.Monsters;
            OnRoundCreate?.Invoke(this);
        }

        public Round(Round previousRound)
        {
        }
    }
}