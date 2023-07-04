using UnityEngine;

namespace CodeBase
{
    [RequireComponent(typeof(Rotator))]
    [RequireComponent(typeof(CoinClickHandler))]
    [RequireComponent(typeof(ColorChanger))]
    public class Coin : MonoBehaviour
    {
        [SerializeField] private Material material;
        
        private Rotator _rotator;
        private ColorChanger _colorChanger;
        private CoinClickHandler _coinClickHandler;

        public void Init()
        {
            _rotator = gameObject.GetComponent<Rotator>();
            _rotator.Init();

            _colorChanger = new ColorChanger(material);

            _coinClickHandler = gameObject.GetComponent<CoinClickHandler>();
            _coinClickHandler.OnCoinClicked += _colorChanger.ChangeColor;
        }
    }
}