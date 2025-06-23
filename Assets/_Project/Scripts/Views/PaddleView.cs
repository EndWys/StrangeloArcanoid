using strange.extensions.mediation.impl;
using UnityEngine;

namespace Assets._Project.Scripts.Views
{
    public class PaddleView : View
    {
        [SerializeField] private float moveSpeed = 5f;
        private float screenHalfWidthInWorldUnits;

        protected override void Start()
        {
            float halfPaddleWidth = transform.localScale.x / 2f;
            float aspect = (float)Screen.width / Screen.height;
            float orthographicSize = Camera.main.orthographicSize;
            screenHalfWidthInWorldUnits = orthographicSize * aspect - halfPaddleWidth;
        }

        public void Move(float direction)
        {
            Vector3 pos = transform.position;
            pos.x += direction * moveSpeed * Time.deltaTime;
            pos.x = Mathf.Clamp(pos.x, -screenHalfWidthInWorldUnits, screenHalfWidthInWorldUnits);
            transform.position = pos;
        }
    }
}