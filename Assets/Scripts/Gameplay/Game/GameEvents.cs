using System;
using UnityEngine;
using UnityEngine.Events;

namespace Gameplay.Game
{
    [Serializable]
    public class FloatEvent : UnityEvent<float>
    {
    }
    
    [Serializable]
    public class TwoFloatEvent : UnityEvent<float, float>
    {
    }

    public class GameEvents : MonoBehaviour
    {
        [Header("UI events")]
        [SerializeField] public FloatEvent UpdateUIPointsEvent;
        [SerializeField] public FloatEvent UpdateUIHpEvent;
        [SerializeField] public TwoFloatEvent GameOverEvent;

        [Header("Game events")] 
        [SerializeField] public FloatEvent AddPointEvent;
        [SerializeField] public UnityEvent PlayerDeadEvent;
    }
}