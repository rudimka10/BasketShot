using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BasketShot.UI
{
    public class LightControl : MonoBehaviour
    {
        [SerializeField] private Color _lightOnColor;
        [SerializeField] private Sprite _lightOnSprite;
        [SerializeField] private Color _lightOffColor;
        [SerializeField] private Sprite _lightOffSprite;
        [Space]
        [SerializeField] private Image _bg;
        [SerializeField] private Image _buttonImage;

        private bool _lightState;


        private void Awake()
        {
            _lightState = PlayerPrefs.GetInt("Light State", 1) == 1 ? true : false;
            SetState();
        }


        public void OnLightButtonClick()
        {
            _lightState = !_lightState;
            PlayerPrefs.SetInt("Light State", _lightState == true ? 1 : 0);
            SetState();

        }

        private void SetState()
        {
            if (_lightState)
            {
                _bg.color = _lightOnColor;
                _buttonImage.sprite = _lightOnSprite;
            }
            else
            {
                _bg.color = _lightOffColor;
                _buttonImage.sprite = _lightOffSprite;
            }
        }
    }
}