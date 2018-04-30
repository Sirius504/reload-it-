using UnityEngine;

namespace ReloadIt
{
    public class PoolableBehavior : MonoBehaviour
    {
        [SerializeField]
        private string path;
        public string ResourcePath
        {
            get
            {
                if (string.IsNullOrEmpty(path))
                    Debug.Log($"Path field on prefab {gameObject.name} is null or empty");                    
                return path;
            }
        }

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