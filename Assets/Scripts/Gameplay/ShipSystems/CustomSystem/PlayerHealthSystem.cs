using System.Collections;
using Gameplay.Game;
using Gameplay.Weapons;
using UnityEngine;

namespace Gameplay.ShipSystems.CustomSystem
{
    public class PlayerHealthSystem : HealthSystem
    {
        IEnumerator Start()
        {
            if (Events == null) yield return null;
            Events.UpdateHp.Invoke(CurrentHp);
        }

        public override void ApplyDamage(IDamageDealer damageDealer)
        {
            CurrentHp -= damageDealer.Damage;
            if (CurrentHp <= 0)
            {
                CurrentHp = 0;
                Events.GameOverEvent.Invoke();
            }
            else
            {
                Events.UpdateHp.Invoke(CurrentHp);
            }
        }
    }
}