using UnityEngine;


namespace Lrw_Manager
{
    public class GameManager : MonoBehaviour
    {
        [field: SerializeField] public bool gameStartMod { get; private set; } = false;
        [field: SerializeField] public bool mapMakeMod { get; private set; } = true;


        public static GameManager instance;

        private void Awake()
        {
            if (instance == null) instance = this;
            else Destroy(gameObject);

            Time.timeScale = gameStartMod ? 1 : 0;

        }

        [ContextMenu("OnChangeMod")]
        public void OnChangeMod()
        {
            gameStartMod = !gameStartMod;
            mapMakeMod = !mapMakeMod;
            Time.timeScale = gameStartMod ? 1 : 0;
        }

        public void OnGameStart()
        {
            gameStartMod = true;
            mapMakeMod = false;
            Time.timeScale = 1;
        }


        public void OnMapMake()
        {
            gameStartMod = false;
            mapMakeMod = true;
            Time.timeScale = 0;
        }


    }
}

