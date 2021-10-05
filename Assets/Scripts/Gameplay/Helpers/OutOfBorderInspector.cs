using UnityEngine;

namespace Gameplay.Helpers
{
    public abstract class OutOfBorderInspector : MonoBehaviour
    {

        [SerializeField]
        protected SpriteRenderer _representation;
    
        void Update()
        {
            CheckBorders();
        }

        protected abstract void CheckBorders();
    }
}
