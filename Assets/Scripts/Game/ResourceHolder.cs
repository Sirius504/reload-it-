using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ReloadIt
{
    public class ResourceHolder : MonoBehaviour
    {
        public List<PoolableBehavior> masterCopies;

        public T GetFromResources<T>() where T : PoolableBehavior
        {
            if (masterCopies.Where(mc => mc.GetType() == typeof(T)).Any())
            {
                T result = (T)Instantiate(masterCopies.Where(mc => mc.GetType() == typeof(T)).FirstOrDefault());
                result.gameObject.SetActive(false);
                return result;
            }
            else Debug.LogError($"Can't find PoolableBehaviour of type {typeof(T)} in master copies");
            throw new Exception("Unreachable code reached");
        }
    }
}