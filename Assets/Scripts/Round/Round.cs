using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Round
{
    public class Round
    {
        private List<Card.Card> _hand;
        private List<Buff.Buff> _playerBuffs;
        public Monster CurrentMonster;

        public Round()
        {
            _hand = new List<Card.Card>();
            _playerBuffs = new List<Buff.Buff>();
        }

        public Round(Round previousRound)
        {
        }
    }
}