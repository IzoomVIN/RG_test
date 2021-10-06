using System;
using UnityEngine;
using UnityEngine.Events;

namespace Gameplay.Game
{
    [Serializable]
    public class StringEvent : UnityEvent<string>
    {
    }

    public class GameEvents : MonoBehaviour
    {
        [Header("UI events")]
        [SerializeField] public StringEvent UpdatePoints;
        [SerializeField] public StringEvent UpdateHp;
        [SerializeField] public UnityEvent GameOverEvent;
    }
}