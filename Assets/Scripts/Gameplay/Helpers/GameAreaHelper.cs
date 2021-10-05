using UnityEngine;

namespace Gameplay.Helpers
{
    public static class GameAreaHelper
    {

        private static Camera _camera;
        private static float _topBound;
        private static float _bottomBound;
        private static float _leftBound;
        private static float _rightBound;
        

        static GameAreaHelper()
        {
            _camera = Camera.main;
        }

        
        public static bool IsInGameplayArea(Transform objectTransform, Bounds objectBounds)
        {
            CalculateBoards();

            var objectPos = objectTransform.position;
            var objectBoundXSize = objectBounds.extents.x / 2;
            var objectBoundYSize = objectBounds.extents.y / 2;

            return (objectPos.x - objectBoundXSize < _rightBound)
                && (objectPos.x + objectBoundXSize > _leftBound)
                && (objectPos.y - objectBoundYSize < _topBound)
                && (objectPos.y + objectBoundYSize > _bottomBound);

        }
        
        public static Vector3 GetPositionInGameplayArea(Transform objectTransform, Bounds objectBounds)
        {
            CalculateBoards();

            var objectPos = objectTransform.position;
            var objectBoundXSize = objectBounds.extents.x / 2;
            var objectBoundYSize = objectBounds.extents.y / 2;
            
            var posInGameplayArea = objectTransform.position;
            
            if (objectPos.x + objectBoundXSize >= _rightBound)
                posInGameplayArea.x = _rightBound;
            else if (objectPos.x - objectBoundXSize <= _leftBound)
                posInGameplayArea.x = _leftBound;
            
            if (objectPos.y + objectBoundYSize >= _topBound)
                posInGameplayArea.y = _topBound;
            else if (objectPos.y - objectBoundYSize <= _bottomBound)
                posInGameplayArea.y = _bottomBound;

            return posInGameplayArea;
        }

        private static void CalculateBoards()
        {
            var camHalfHeight = _camera.orthographicSize;
            var camHalfWidth = camHalfHeight * _camera.aspect;
            var camPos = _camera.transform.position;
            _topBound = camPos.y + camHalfHeight;
            _bottomBound = camPos.y - camHalfHeight;
            _leftBound = camPos.x - camHalfWidth;
            _rightBound = camPos.x + camHalfWidth;
        }

    }
}
