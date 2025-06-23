using Assets._Project.Scripts.Commands;
using Assets._Project.Scripts.Mediators;
using Assets._Project.Scripts.Services;
using Assets._Project.Scripts.Signals;
using Assets._Project.Scripts.Views;
using strange.extensions.command.api;
using strange.extensions.command.impl;
using strange.extensions.context.impl;
using UnityEngine;

namespace Assets._Project.Scripts.Contexts
{
    public class GameContext : MVCSContext
    {
        public GameContext(MonoBehaviour view) : base(view) { }

        protected override void addCoreComponents()
        {
            base.addCoreComponents();
            injectionBinder.Unbind<ICommandBinder>();
            injectionBinder.Bind<ICommandBinder>().To<SignalCommandBinder>().ToSingleton();
        }

        protected override void mapBindings()
        {
            // === SIGNALS ===
            injectionBinder.Bind<GameStartSignal>().ToSingleton();
            injectionBinder.Bind<BallHitBlockSignal>().ToSingleton();

            // === MODELS ===
            //injectionBinder.Bind<GameModel>().ToSingleton();

            // === SERVICES ===
            injectionBinder.Bind<IGameService>().To<GameService>().ToSingleton();

            // === COMMANDS ===
            commandBinder.Bind<GameStartSignal>().To<GameStartCommand>();
            commandBinder.Bind<BallHitBlockSignal>().To<DestroyBlockCommand>();

            // === VIEW ↔ MEDIATOR ===
            mediationBinder.BindView<PaddleView>().ToMediator<PaddleMediator>();
            mediationBinder.BindView<BallView>().ToMediator<BallMediator>();
            mediationBinder.BindView<BlockView>().ToMediator<BlockMediator>();


            // === MONOBEHAVIOURS (ToValue) ===
        }

        public override void Launch()
        {
            base.Launch();

            var startSignal = injectionBinder.GetInstance<GameStartSignal>();
            startSignal.Dispatch();
        }
    }
}