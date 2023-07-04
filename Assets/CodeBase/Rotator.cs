using UnityEngine;

namespace CodeBase
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] private float rotationSpeed;

        private Transform _transform;
        
        public void Init()
        {
            _transform = gameObject.GetComponent<Transform>();
        }
        
        private void Update()
        {
            _transform.Rotate(new Vector3(0, rotationSpeed, 0));
        }
    }
}
