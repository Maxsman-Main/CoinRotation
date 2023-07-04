using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CodeBase
{
    public class CoinClickHandler : MonoBehaviour, IPointerClickHandler
    {
        public event Action OnCoinClicked;
        
        public void OnPointerClick(PointerEventData eventData)
        {
            OnCoinClicked?.Invoke();
        }
    }
}