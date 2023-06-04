using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Gridlock
{
	public class Being : MonoBehaviour
	{
        [SerializeField]
        private float movementDuration = 0.5f;

        private bool isMoving = false;

        [Button]
        public void Move(Vector2Int newInput)
        {
            if (isMoving)
            {
                return;
            }

            isMoving = true;

            transform.DOLocalMove(transform.localPosition + newInput.ToVector3(), movementDuration)
                .OnComplete(() => isMoving = false);
        }
    }
}