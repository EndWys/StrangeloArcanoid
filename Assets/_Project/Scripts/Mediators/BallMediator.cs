using Assets._Project.Scripts.Views;
using strange.extensions.mediation.impl;
using UnityEngine;

namespace Assets._Project.Scripts.Mediators
{
    public class BallMediator : Mediator
    {
        [Inject] public BallView view { get; set; }

        public override void OnRegister()
        {
            Debug.Log("BallMediator registered");

            
            view.ResetBall(Vector3.zero);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                view.Launch();
            }
        }
    }
}