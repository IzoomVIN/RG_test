using System.Collections;
using Gameplay.Weapons.Projectiles;
using UnityEngine;

namespace Gameplay.Weapons
{
    public abstract class Weapon : MonoBehaviour
    {

        [SerializeField] private protected Transform _barrel;
        [SerializeField] private float _cooldown;
        
        private bool _readyToFire = true;
        private protected UnitBattleIdentity _battleIdentity;
        
        
        
        public void Init(UnitBattleIdentity battleIdentity)
        {
            _battleIdentity = battleIdentity;
        }
        
        
        public void TriggerFire()
        {
            if (!_readyToFire)
                return;
            
            InitProjectile();
            StartCoroutine(Reload(_cooldown));
        }

        private IEnumerator Reload(float cooldown)
        {
            _readyToFire = false;
            yield return new WaitForSeconds(cooldown);
            _readyToFire = true;
        }

        protected abstract void InitProjectile();
    }
}
