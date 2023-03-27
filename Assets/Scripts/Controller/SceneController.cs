using Manager;
using UnityEngine;
using KapaiGame;
using Prefabs.Card;

namespace Controller
{
    public class SceneController : MonoBehaviour
    {
        public Canvas canvas;
        public GameObject skillCardPrefab;

        void Awake()
        {
            GameManager.Instance.OnFloorChanged += RenderFloorInfo;
        }

        private void InitANewRound()
        {
            var round = new Round();
            RenderRound(round);
        }

        // Update is called once per frame
        void Update()
        {
        }

        void RenderFloorInfo(TowerFloor towerFloor)
        {
            InitANewRound();
        }

        void RenderRound(Round round)
        {
            Transform handPanel = canvas.transform.Find("HandPanel");
            foreach (var card in round.hand)
            {
                GameObject cardInstance = Instantiate(skillCardPrefab, handPanel); // 实例化卡片预制件，并设置其父对象为HandPanel
                SkillCardController
                    cardController = cardInstance.GetComponent<SkillCardController>(); // 获取卡片实例上的CardController组件
                cardController.SetCardData(card as SkillCard);
            }
        }
    }
}