using Gameplay.Weapons;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

namespace Gameplay.Bonuses
{
    public abstract class Bonus : MonoBehaviour
    {
        [SerializeField] private Vector2 movementSpeedRange;

        private float _movementSpeed;
        private protected UnitBattleIdentity anchorIdentity;

        public void Init(UnitBattleIdentity unitBattleIdentity)
        {
            anchorIdentity = unitBattleIdentity;
            _movementSpeed = Random.Range(movementSpeedRange.x, movementSpeedRange.y);
        }

        void FixedUpdate()
        {
            var movement = _movementSpeed * Time.fixedDeltaTime;
            transform.Translate(movement * Vector3.up.normalized);
        }
    }
}