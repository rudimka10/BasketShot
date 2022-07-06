using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace BasketShot.UI
{
    public class StarsPanel : MonoBehaviour
    {
        [SerializeField] private TMP_Text _starsValueLabel;

        private void Awake()
        {
            // TODO: добавить подписку на изменение значения звёзд
        }

        private void UpdateLabel()
        {

        }

        private void OnDisable()
        {
            // TODO: добавить отписку на изменение значения звёзд

        }

    }
}