using System.Collections.Generic;
using UnityEngine;

namespace TomGustin.GameDesignPattern
{
    public abstract class Subject : MonoBehaviour
    {
        protected List<IObserver> observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            if (!observers.Contains(observer)) observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            if (observers.Contains(observer)) observers.Remove(observer);
        }

        public void OnNotify<T>(T param)
        {
            foreach (IObserver observer in observers) observer.OnNotify(param);
        }

        public virtual void OnNotify<T>(string sender, T param) { }
    }
}