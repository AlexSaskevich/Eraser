using ScratchCardAsset;
using System;
using UnityEngine;

namespace Assets.Source
{
    public class Progress : MonoBehaviour
    {
        [SerializeField] private ScratchCardManager _cardManager;
        [Range(0, 1)][SerializeField] private float _progressPercentToComplete;

        private void OnEnable()
        {
            _cardManager.Progress.OnProgress += OnScratchProgress;
        }

        private void OnDisable()
        {
            _cardManager.Progress.OnProgress -= OnScratchProgress;
        }

        private void Update()
        {
            if (_cardManager.Card.IsScratching == false)
                _cardManager.Card.ClearInstantly();
        }

        private void OnScratchProgress(float progress)
        {
            if (progress >= _progressPercentToComplete)
            {
                _cardManager.Card.FillInstantly();
                _cardManager.Card.InputEnabled = false;
            }
        }
    }
}