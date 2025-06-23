using Assets._Project.Scripts.Signals;
using UnityEngine;

namespace Assets._Project.Scripts.Bootstrap
{
    public class GameBootstrap : MonoBehaviour
    {
        [Inject] public GameStartSignal GameStartSignal { get; set; }

        void Start()
        {
            Debug.Log("Dispatching GameStartSignal...");
            //GameStartSignal.Dispatch();
        }
    }
}