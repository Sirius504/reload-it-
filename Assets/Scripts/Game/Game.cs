using ReloadIt.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReloadIt
{
    public class Game : MonoBehaviour
    {
        public ResourceHolder ResourceHolder { get; private set; }
        public PoolManager PoolManager { get; private set; }
        public IngameGui IngameGui { get; private set; }
        public Player Player { get; private set; }

        public void Init()
        {
            ResourceHolder = this.Get<ResourceHolder>("ResourceHolder");
            PoolManager = this.Get<PoolManager>("PoolManager");
            IngameGui = this.Get<IngameGui>("IngameGui");
            Player = this.Get<Player>("Player");

            IngameGui.Init();
            PoolManager.Init();
        }
    }
}