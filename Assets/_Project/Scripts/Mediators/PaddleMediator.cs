using Assets._Project.Scripts.Views;
using strange.extensions.mediation.impl;
using UnityEngine;

public class PaddleMediator : Mediator
{
    [Inject] public PaddleView View { get; set; }

    public override void OnRegister()
    {
        Debug.Log("PaddleMediator registered");
    }

    private void Update()
    {
        float input = Input.GetAxis("Horizontal");
        View.Move(input);
    }
}