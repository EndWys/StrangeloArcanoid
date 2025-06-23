using Assets._Project.Scripts.Services;
using strange.extensions.command.impl;
using UnityEngine;

namespace Assets._Project.Scripts.Commands
{
    public class GameStartCommand : Command
    {
        [Inject] public IGameService GameService { get; set; }

        public override void Execute()
        {
            Debug.Log("Execute");

            GameService.StartGame();
        }
    }
}