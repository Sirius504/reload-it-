using UnityEngine;
using System.Collections;
namespace ReloadIt
{
    public static class Extentions
    {
        public static T Get<T>(this MonoBehaviour mb, string path) where T : Component
        {
            Transform child = mb.transform.Find(path);
            if (child == null)
            {
                Debug.LogError(string.Format($"Cannot find children on path: {path}"));
                return null;
            }
            T component = child.GetComponent<T>();
            if (component == null)
            {
                Debug.LogError($"Cannot find component {typeof(T).ToString()} on path {path}");
                return null;
            }
            return component;
        }
    }
}