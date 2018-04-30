using UnityEngine;

namespace ReloadIt
{
    public class App : MonoBehaviour
    {
        public static Game Game;

        private void Awake()
        {
            Game = GetComponentInChildren<Game>();
            Game.Init();
        }
    }
}
