using Gameplay.Game;

namespace Gameplay.Spaceships.CustomSpaceships
{
    public class EnemySpaceship: Spaceship
    {
        public void Init(GameEvents events)
        {
            _events = events;
        }
    }
}