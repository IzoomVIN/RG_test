using System;
using Gameplay.Game;
using Gameplay.ShipControllers;
using Gameplay.ShipSystems;
using Gameplay.Weapons;
using UnityEngine;

namespace Gameplay.Spaceships
{
    public abstract class Spaceship : MonoBehaviour, ISpaceship
    {
        [Header("Systems")]
        [SerializeField] private ShipController _shipController;
        [SerializeField] private MovementSystem _movementSystem;
        [SerializeField] private WeaponSystem _weaponSystem;
        [SerializeField] private HealthSystem _healthSystem;
        
        [Header("Properties")]
        [SerializeField] private UnitBattleIdentity _battleIdentity;

        private protected GameEvents _events;

        public MovementSystem MovementSystem => _movementSystem;
        public WeaponSystem WeaponSystem => _weaponSystem;

        public UnitBattleIdentity BattleIdentity => _battleIdentity;

        private void Start()
        {
            _shipController.Init(this);
            _weaponSystem.Init(_battleIdentity);
            _healthSystem.Init(_events, _battleIdentity);
        }
    }
}
