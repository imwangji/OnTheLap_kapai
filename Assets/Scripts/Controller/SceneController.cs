using Manager;
using UnityEngine;
using KapaiGame;
namespace Controller
{
    public class SceneController : MonoBehaviour
    {
        public Canvas canvas; 
        void Start()
        {
            GameManager.Instance.OnFloorChanged += RenderFloorInfo;
        }

        private void InitANewRound()
        {
            var round = new Round();
            round.OnRoundCreate += RenderRound;
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
            
        }
    }
}
