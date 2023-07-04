using UnityEngine;

namespace CodeBase
{
    public class ColorChanger
    {
        private readonly Material _material;

        public ColorChanger(Material material)
        {
            _material = material;
        }
        
        public void ChangeColor()
        {
            _material.color = Random.ColorHSV();
        }
    }
}