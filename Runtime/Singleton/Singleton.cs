using UnityEngine;

namespace TomGustin.GameDesignPattern
{
    public abstract class Singleton<T> : MonoBehaviour
    {
        public static T Instance
        {
            get
            {
                if (_instance == null) Debug.LogError("You must call OnInitialize on the Awake method of class that using singleton!");
                return _instance;
            }
        }
        private static T _instance;

        protected virtual void OnInitialize()
        {
            if (_instance == null)
            {
                _instance = (T) (object) this;
                DontDestroyOnLoad(this);
            } else
            {
                Destroy(gameObject);
            }
        }
    }
}
