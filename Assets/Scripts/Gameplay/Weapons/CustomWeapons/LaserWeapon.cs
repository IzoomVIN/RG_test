using Gameplay.Weapons.Projectiles;
using UnityEngine;

namespace Gameplay.Weapons.CustomWeapons
{
    public class LaserWeapon : Weapon
    {
        [SerializeField] private LaserBeam _projectile;
        
        protected override void InitProjectile()
        {
            var proj = Instantiate(_projectile, _barrel.position, _barrel.rotation);
            proj.Init(_battleIdentity);
        }

    }
}