using Gameplay.Weapons;
using UnityEngine;

namespace Gameplay.Bonuses.CustomBonuses.HealthBonus
{
    public class HealthBonus : Bonus, IHealDealer
    {
        [SerializeField] private float health;
        
        public UnitBattleIdentity AnchorIdentity => anchorIdentity;
        public float Health => health;
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            
            var healableObjects = other.gameObject.GetComponentsInChildren<IHealable>();
            var isCured = false;

            foreach (var healableObject in healableObjects)
            {
                if (healableObject.BattleIdentity == AnchorIdentity)
                {
                    healableObject.ApplyHealth(this);
                    isCured = true;
                }
            }
            
            if (healableObjects.Length != 0 && isCured) Destroy(gameObject);
        }
    }
}