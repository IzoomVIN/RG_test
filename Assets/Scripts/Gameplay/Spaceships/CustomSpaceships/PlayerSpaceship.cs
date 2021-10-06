using Gameplay.Game;
using UnityEngine;

namespace Gameplay.Spaceships.CustomSpaceships
{
    public class PlayerSpaceship: Spaceship
    {
        [SerializeField] private GameEvents gameEvents;
        
        void Awake()
        {
            _events = gameEvents;
        }
    }
}