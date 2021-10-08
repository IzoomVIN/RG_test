using System.Collections;
using Gameplay.Bonuses.CustomBonuses.HealthBonus;
using Gameplay.Game;
using Gameplay.Weapons;
using UnityEngine;

namespace Gameplay.ShipSystems.CustomSystem
{
    public class PlayerHealthSystem : HealthSystem, IHealable
    {
        IEnumerator Start()
        {
            if (Events == null) yield return null;
            Events.UpdateUIHpEvent.Invoke(CurrentHp);
        }

        public override void ApplyDamage(IDamageDealer damageDealer)
        {
            CurrentHp -= damageDealer.Damage;
            if (CurrentHp <= 0)
            {
                CurrentHp = 0;
                Events.PlayerDeadEvent.Invoke();
                Destroy(gameObject);
            }
            else
            {
                Events.UpdateUIHpEvent.Invoke(CurrentHp);
            }
        }

        public void ApplyHealth(IHealDealer healDealer)
        {
            CurrentHp += healDealer.Health;
            
            if (CurrentHp > hpCount) CurrentHp = hpCount;
            Events.UpdateUIHpEvent.Invoke(CurrentHp);
        }
    }
}