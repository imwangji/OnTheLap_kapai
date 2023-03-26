using Manager;
using UnityEngine;
namespace Controller
{
    public class SceneController : MonoBehaviour
    {
        public Canvas canvas; 
        void Start()
        {
            GameManager.Instance.OnFloorChanged += RenderFloorInfo;
            InitANewRound();
        }

        private void InitANewRound()
        {
            var round = new Round.Round();
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        void RenderFloorInfo(TowerFloor towerFloor)
        {
        
        }
    }
}
