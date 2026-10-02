using UnityEngine;
using UnityEngine.UI;

namespace CVG42.SceneManagement.SceneReference.Samples
{
    public class LoadSceneButton : MonoBehaviour
    {
        [SerializeField] private SceneReference _levelScene;

        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void Start()
        {
            _button.onClick.AddListener(LoadGameScene);
            _button.interactable = true;
        }

        private void LoadGameScene()
        {
            LoadSceneManager.Source.LoadScene(_levelScene);
        }
    }
}