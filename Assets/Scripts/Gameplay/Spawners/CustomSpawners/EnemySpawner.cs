using Gameplay.Game;
using Gameplay.Spaceships.CustomSpaceships;
using UnityEngine;

namespace Gameplay.Spawners.CustomSpawners
{
    public class EnemySpawner: Spawner
    {
        [Header("Enemy properties")]
        [SerializeField] private GameEvents events;
        
        protected override void InitObject(GameObject obj)
        {
            obj.GetComponent<EnemySpaceship>().Init(events);
            obj.SetActive(true);
        }
    }
}