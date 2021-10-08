using Gameplay.Weapons;
using UnityEngine;

namespace Gameplay.Bonuses
{
    public class BonusManager : MonoBehaviour
    {
        [SerializeField, Range(0,1)] private float probability;
        [SerializeField] private UnitBattleIdentity anchorIdentity;
        [SerializeField] private Bonus[] bonuses;

        public void InstantiateBonus(Vector3 startPosition, Quaternion startRotation)
        {
            if (bonuses.Length == 0) return;
            if(Random.Range(0f,1f) > probability) return;

            var bonusPrefab = bonuses[Random.Range(0, bonuses.Length)];
            
            var bonus = Instantiate(bonusPrefab, startPosition, startRotation);
            bonus.Init(anchorIdentity);
            
        }

    }
}