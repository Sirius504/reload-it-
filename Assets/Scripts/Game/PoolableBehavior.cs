using UnityEngine;

namespace ReloadIt
{
    public class PoolableBehavior : MonoBehaviour
    {
        public void PutToPool()
        {
            App.Game.PoolManager.PutToPool(this);
        }

        public static T GetFromPool<T>(Transform parent) where T : PoolableBehavior
        {
            return (T)App.Game.PoolManager.GetFromPool<T>(parent);
        }

        public static T GetFromPool<T>(Transform parent, Vector3 position, Quaternion rotation) where T : PoolableBehavior
        {
            return (T)App.Game.PoolManager.GetFromPool<T>(parent, position, rotation);
        }
    }
}