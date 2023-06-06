using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Source
{
    public class Restart : MonoBehaviour
    {
        [SerializeField] private Button _button;

        private void OnEnable()
        {
            _button.onClick.AddListener(OnButtonClick);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}