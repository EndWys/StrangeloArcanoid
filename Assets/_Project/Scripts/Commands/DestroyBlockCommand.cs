using Assets._Project.Scripts.Views;
using strange.extensions.command.impl;
using UnityEngine;

namespace Assets._Project.Scripts.Commands
{
    public class DestroyBlockCommand : Command
    {
        [Inject] public BlockView block { get; set; }

        public override void Execute()
        {
            Debug.Log("Execute");
            block.DestroyBlock();
        }
    }
}