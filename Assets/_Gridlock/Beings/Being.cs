using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Gridlock
{
	public class Being : MonoBehaviour
	{
        [SerializeField]
        private float movementDuration = 0.5f;

        [Button]
        public void Move(Vector2Int newPosition)
        {
            transform.DOLocalMove(newPosition.ToVector3(), movementDuration);
        }
    }
}