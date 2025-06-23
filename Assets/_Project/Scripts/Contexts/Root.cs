using strange.extensions.context.impl;

namespace Assets._Project.Scripts.Contexts
{
    public class Root : ContextView
    {
        void Awake()
        {
            context = new GameContext(this);
        }
    }
}