using Assets._Project.Scripts.Signals;
using Assets._Project.Scripts.Views;
using strange.extensions.mediation.impl;
using UnityEngine;

namespace Assets._Project.Scripts.Mediators
{
    public class BlockMediator : Mediator
    {
        [Inject] public BlockView view { get; set; }
        [Inject] public BallHitBlockSignal ballHitBlockSignal { get; set; }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.GetComponent<BallView>() != null)
            {
                Debug.Log("Hit Block");
                ballHitBlockSignal.Dispatch(view);
            }
        }
    }
}