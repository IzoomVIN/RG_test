using UnityEngine;

namespace Gameplay.Weapons.Projectiles.CustomProjectiles
{
    public class Rocket : Projectile
    {
        [SerializeField] private float rotationSpeed;
        private Vector2 thisForvard;
        private Vector2 anchorForvard;
        
        // rotation rocket to forward of anchor
        private Transform _rotationAnchor;

        public void Init(UnitBattleIdentity battleIdentity, Transform rotationAnchor)
        {
            base.Init(battleIdentity);
            _rotationAnchor = rotationAnchor;
        }

        protected override void Move(float speed)
        {
            transform.Translate(speed * Time.fixedDeltaTime * Vector3.up);
            
            if(_rotationAnchor != null) Rotation();
        }
        
        protected void Rotation()
        {
            thisForvard = new Vector2(transform.up.x, transform.up.y);
            anchorForvard = new Vector2(_rotationAnchor.transform.up.x, _rotationAnchor.transform.up.y);

            if (thisForvard.Equals(anchorForvard)) return;

            var angle = Vector2.SignedAngle(thisForvard, anchorForvard);
            angle *= (rotationSpeed * Time.fixedDeltaTime);
            
            transform.Rotate(Vector3.forward, angle);;
        }
    }
}