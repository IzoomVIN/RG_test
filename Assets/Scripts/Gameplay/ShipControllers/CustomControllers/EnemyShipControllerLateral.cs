using Gameplay.ShipSystems;
using UnityEngine;

namespace Gameplay.ShipControllers.CustomControllers
{
    public class EnemyShipControllerLateral : EnemyShipController
    {
        [SerializeField] private Vector2 displacement;

        private float _lateral;
        private float _startPosition;
        private float _nextPosition;
        private bool _currentIsLeft;

        void Start()
        {
            _lateral = Random.Range(displacement.x, displacement.y);
            _currentIsLeft = Random.Range(0, 1) == 1;

            _startPosition = transform.position.x;
            UpdateNextPosition();
        }

        protected override void ProcessHandling(MovementSystem movementSystem)
        {
            base.ProcessHandling(movementSystem);
            LateralMovement(movementSystem); 
        }

        private void LateralMovement(MovementSystem movementSystem)
        {
            if(isPositionPassed()) UpdateNextPosition();
            
            var moveAmount = Time.deltaTime;
            if(!_currentIsLeft) moveAmount *= -1;
                
            movementSystem.LateralMovement(moveAmount);
        }

        private bool isPositionPassed()
        {
            var thisX = transform.position.x;
            var posX = _nextPosition;
            
            var checkResult = thisX >= posX;
            if (_currentIsLeft) checkResult = !checkResult;
            
            return checkResult;
        }

        private void UpdateNextPosition()
        {
            _currentIsLeft = !_currentIsLeft;
            var displace = _currentIsLeft ? -_lateral : _lateral;
            _nextPosition = _startPosition + displace;
        }
    }
}