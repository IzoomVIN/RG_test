using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UI
{
    public class UIManager: MonoBehaviour
    {
        [SerializeField] private Text pointsField;
        [SerializeField] private Text hpField;

        
        public void SetPoints(float value)
        {
            pointsField.text = value.ToString("0");
        }
        
        
        public void SetHp(float value)
        {
            hpField.text = value.ToString("0");
        }
    }
}