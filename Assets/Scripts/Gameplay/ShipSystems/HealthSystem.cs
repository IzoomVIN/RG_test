using Gameplay.Game;
using Gameplay.Weapons;
using UnityEngine;

namespace Gameplay.ShipSystems
{
    public abstract class HealthSystem : MonoBehaviour, IDamagable
    {
        [SerializeField] private protected float hpCount;
        private protected float CurrentHp;

        private protected GameEvents Events;
        

        public void Init(GameEvents events, UnitBattleIdentity battleIdentity)
        {
            BattleIdentity = battleIdentity;
            Events = events;
            CurrentHp = hpCount;
        }


        public abstract void ApplyDamage(IDamageDealer damageDealer);
        public UnitBattleIdentity BattleIdentity { get; private set; }
    }
}