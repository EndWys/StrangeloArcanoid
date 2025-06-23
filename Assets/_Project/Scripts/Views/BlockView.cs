using strange.extensions.mediation.impl;
using UnityEngine;

namespace Assets._Project.Scripts.Views
{
    [RequireComponent(typeof(Collider2D))]
    public class BlockView : View
    {
        public void DestroyBlock()
        {
            Destroy(gameObject);
        }
    }
}