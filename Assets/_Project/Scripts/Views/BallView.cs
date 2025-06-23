using strange.extensions.mediation.impl;
using UnityEngine;

namespace Assets._Project.Scripts.Views
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class BallView : View
    {
        [SerializeField] private Rigidbody2D rb;
        [SerializeField] private float launchForce = 5f;

        private bool isLaunched = false;

        protected override void Awake()
        {
            base.Awake();
        }

        public void Launch()
        {
            if (isLaunched) return;

            isLaunched = true;
            rb.velocity = Vector2.up * launchForce;
        }

        public void ResetBall(Vector3 position)
        {
            isLaunched = false;
            rb.velocity = Vector2.zero;
            transform.position = position;
        }
    }
}