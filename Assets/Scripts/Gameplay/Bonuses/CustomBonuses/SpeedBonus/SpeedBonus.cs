using Gameplay.Bonuses.CustomBonuses.HealthBonus;
using Gameplay.Weapons;
using UnityEngine;

namespace Gameplay.Bonuses.CustomBonuses.SpeedBonus
{
    public class SpeedBonus : Bonus, ISpeedDealer
    {
        [SerializeField] private float speedInPercent;

        public UnitBattleIdentity AnchorIdentity => anchorIdentity;
        public float Speed => speedInPercent/100;

        private void OnCollisionEnter2D(Collision2D other)
        {

            var healableObjects = other.gameObject.GetComponentsInChildren<ISpeedable>();
            var isSpedUp = false;

            foreach (var healableObject in healableObjects)
            {
                if (healableObject.BattleIdentity == AnchorIdentity)
                {
                    healableObject.ApplySpeed(this);
                    isSpedUp = true;
                }
            }

            if (healableObjects.Length != 0 && isSpedUp) Destroy(gameObject);
        }
    }
}