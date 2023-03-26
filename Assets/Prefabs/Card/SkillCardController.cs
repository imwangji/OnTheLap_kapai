using Card;
using TMPro;
using UnityEngine;

namespace Prefabs.Card
{
    public class SkillCardController : MonoBehaviour
    {
        private SkillCard _card;
        public TextMeshProUGUI cost;
        public TextMeshProUGUI attackPower;
        public TextMeshProUGUI buffDescriptions;
        void SetCardData(SkillCard card)
        {
            _card = card;
        }

        // Update is called once per frame
        void Update()
        {
            if (_card != null)
            {
                cost.text = _card.Cost.ToString();
                attackPower.text = _card.Damage.ToString();
                buffDescriptions.text = _card.Cost.ToString();
            }
        }
    }
}
