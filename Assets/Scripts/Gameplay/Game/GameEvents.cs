using System;
using UnityEngine;
using UnityEngine.Events;

namespace Gameplay.Game
{
    [Serializable]
    public class FloatEvent : UnityEvent<float>
    {
    }

    public class GameEvents : MonoBehaviour
    {
        [Header("UI events")]
        [SerializeField] public FloatEvent UpdatePoints;
        [SerializeField] public FloatEvent UpdateHp;
        [SerializeField] public UnityEvent GameOverEvent;
    }
}