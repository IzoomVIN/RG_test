using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Gameplay.UI
{
    public class UIManager: MonoBehaviour
    {
        [Header("Panels")]
        [SerializeField] private GameObject gamePanel;
        [SerializeField] private GameObject gameOverPanel;
        
        [Header("Game panel elements")]
        [SerializeField] private Text pointsField;
        [SerializeField] private Text hpField;
        
        [Header("GameOver panel elements")]
        [SerializeField] private Text recordField;

        void Start()
        {
            gamePanel.SetActive(true);
            gameOverPanel.SetActive(false);
        }

        public void SetPoints(float value)
        {
            pointsField.text = value.ToString("0");
        }

        public void SetHp(float value)
        {
            hpField.text = value.ToString("0");
        }
        
        public void OnGameOver(float value, float effectDuration)
        {
            StartCoroutine(DeadEffect(value, effectDuration));
        }

        public void OnRestartButton()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        IEnumerator DeadEffect(float value, float effectTime)
        {
            gamePanel.SetActive(false);

            var delta = effectTime;
            var step = 0.1f;
            while (delta >= 0)
            {
                var timeScale = 1 - (effectTime - delta) / effectTime;
                if (timeScale < 0) timeScale = 0;
                Time.timeScale = timeScale;

                yield return new WaitForSecondsRealtime(step);
                delta -= step;
            }
            
            recordField.text = value.ToString("0");
            gameOverPanel.SetActive(true);
        }
    }
}