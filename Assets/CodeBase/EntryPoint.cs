using UnityEngine;

namespace CodeBase
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private Coin coin;

        private void Start()
        {
            Init();
        }

        private void Init()
        {
            coin.Init();
        }
    }
}