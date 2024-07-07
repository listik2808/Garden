using System;
using UnityEngine;
using UnityEngine.UI;

namespace Screpts.ClickButton
{
    public class ButtonClick : MonoBehaviour
    {
        [SerializeField] private Button _button;

        public event Action OpenScreen;

        private void OnEnable()
        {
            _button.onClick.AddListener(OnClick);
        }
        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            OpenScreen?.Invoke();
        }
    }
}