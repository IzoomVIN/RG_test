using Gameplay.Helpers;
using UnityEngine;

namespace Gameplay.Game
{
    public class GameManager : MonoBehaviour
    {
        [Header("Game properties")]
        [SerializeField] private Camera camera;
        [SerializeField] private GameEvents events;
        
        [Header("Game over properties")]
        [SerializeField] private float effectDurationInSec;

        private float _points = 0;

        void Start()
        {
            Time.timeScale = 1f;
            GameAreaHelper.Init(camera);
        }

        public void AddPoints(float value)
        {
            _points += value;
            events.UpdateUIPointsEvent.Invoke(_points);
        }

        public void OnPlayerDead()
        {
            events.GameOverEvent.Invoke(_points, effectDurationInSec);
        }
    }
}