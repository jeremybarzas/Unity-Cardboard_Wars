using UnityEngine;
using System.Linq;

public class ScriptableSingleton<T> : ScriptableObject where T : ScriptableObject
{
    protected static T _instance;

    public static T Instance
    {
        get
        {
            if (!_instance)
                _instance = Resources.FindObjectsOfTypeAll<T>().FirstOrDefault();
            if (!_instance)
                _instance = CreateInstance<T>();
            return _instance;
        }
    }
}