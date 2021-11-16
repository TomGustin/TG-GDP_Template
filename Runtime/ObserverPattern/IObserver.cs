using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TomGustin.GameDesignPattern
{
    public interface IObserver
    {
        void OnNotify<T>(T param);
        void OnNotify<T>(string sender, T param);
    }
}