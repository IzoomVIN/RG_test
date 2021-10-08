using Gameplay.Weapons.Projectiles.CustomProjectiles;
using UnityEngine;

namespace Gameplay.Weapons.CustomWeapons
{
    public class RocketWeapon : Weapon
    {
        [SerializeField] private Rocket projectile;
        [SerializeField] private Transform rotationAnchor;
        
        protected override void InitProjectile()
        {
            var proj = Instantiate(projectile, _barrel.position, _barrel.rotation);
            proj.Init(_battleIdentity, rotationAnchor);
        }
    }
}