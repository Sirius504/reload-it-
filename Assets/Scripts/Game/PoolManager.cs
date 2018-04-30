using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ReloadIt
{
    public class PoolManager : MonoBehaviour
    {
        private Dictionary<System.Type, List<PoolableBehavior>> pooled;

        public void Init()
        {
            pooled = new Dictionary<System.Type, List<PoolableBehavior>>();
        }

        public void PutToPool(PoolableBehavior pb)
        {
            System.Type key = pb.GetType();
            pb.gameObject.SetActive(false);
            pb.transform.SetParent(transform);
            if (pooled.ContainsKey(key))
                pooled[key].Add(pb);
            else
                pooled.Add(key, new List<PoolableBehavior>() { pb });            
        }

        public T GetFromPool<T>(Transform parent, Vector3 position, Quaternion rotation) where T : PoolableBehavior
        {
            System.Type key = typeof(T);
            T result;
            if (pooled.ContainsKey(key))
            {
                result = (T)pooled[key].First();
                pooled[key].Remove(result);
                if (!pooled[key].Any())
                    pooled.Remove(key);
            }
            else
                result = App.Game.ResourceHolder.GetFromResources<T>();            
            result.transform.SetParent(parent);
            result.transform.position = position;
            result.transform.rotation = rotation;
            result.gameObject.SetActive(true);
            return result;
        }

        public T GetFromPool<T>(Transform parent) where T : PoolableBehavior
        {
            return GetFromPool<T>(parent, Vector3.zero, Quaternion.identity);
        }
    }
}
