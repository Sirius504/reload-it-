using ReloadIt.UI;
using UnityEngine;

namespace ReloadIt
{
    public class Game : MonoBehaviour
    {
        public ResourceHolder ResourceHolder { get; private set; }
        public PoolManager PoolManager { get; private set; }
        public IngameGui IngameGui { get; private set; }
        public GuiManager Gui { get; private set; }
        public Player Player { get; private set; }

        public FiniteStateMachine<Game> fsm;

        public void Init()
        {
            ResourceHolder = this.Get<ResourceHolder>("ResourceHolder");
            PoolManager = this.Get<PoolManager>("PoolManager");
            IngameGui = this.Get<IngameGui>("IngameGui");
            Player = this.Get<Player>("Player");

            fsm = new FiniteStateMachine<Game>();
            fsm.Configure(this, InitState.Instance);
            IngameGui.Init();
            PoolManager.Init();
        }

        public void GameOver_Enter()
        {
            Debug.Log("Всё, пизда");
        }
    }
}