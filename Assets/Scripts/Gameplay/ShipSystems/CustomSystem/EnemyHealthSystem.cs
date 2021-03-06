using Gameplay.Weapons;
using UnityEngine;

namespace Gameplay.ShipSystems.CustomSystem
{
    public class EnemyHealthSystem: HealthSystem
    {
        [SerializeField] private float pointCost;
        
        public override void ApplyDamage(IDamageDealer damageDealer)
        {
            CurrentHp -= damageDealer.Damage;
            if (CurrentHp <= 0)
            {
                CurrentHp = 0;
                Events.AddPointEvent.Invoke(pointCost);
                Events.BonusEvent.Invoke(transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }
}