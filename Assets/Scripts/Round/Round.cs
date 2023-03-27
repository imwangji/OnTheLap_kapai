using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Manager;
using UnityEngine;

namespace KapaiGame
{
    public class Round
    {
        public List<Card> hand;
        public List<Buff.Buff> playerBuffs;
        public List<Monster> currentMonsters;

        public event Action<Round> OnRoundCreate;
        public Round()
        {
            hand = CardManager.Instance.DrawCard();
            playerBuffs = new List<Buff.Buff>();
            currentMonsters = GameManager.Instance.CurrentFloor.Monsters;
        }

        public Round(Round previousRound)
        {
        }
    }
}