using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UI
{
    public class UIManager: MonoBehaviour
    {
        [SerializeField] private Text pointsField;
        [SerializeField] private Text hpField;

        
        public void SetPoints(string value)
        {
            Debug.Log($"set points {value}");
            pointsField.text = value;
        }
        
        
        public void SetHp(string value)
        {
            hpField.text = value;
        }
    }
}