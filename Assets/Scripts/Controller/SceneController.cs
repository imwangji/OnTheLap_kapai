using UnityEngine;

namespace Controller
{
    public class SceneController : MonoBehaviour
    {
        public Canvas canvas; 
        void Start()
        {
            GameManager.Instance.OnFloorChanged += RenderScene;
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        void RenderScene(TowerFloor towerFloor)
        {
        
        }
    }
}
