using System.Collections.Generic;
using UnityEngine;

namespace Gridlock{
	public class BeingManager : MonoBehaviour
	{
        [SerializeField]
        private Being enemyPrefab;

        [SerializeField]
        private Being playerPrefab;

        [SerializeField]
        private Transform beingContainer;

        private Dictionary<Vector2Int, Being> beingByPosition = new();


        private void Start()
        {
            CreateBeing(playerPrefab, new Vector2Int(5,1));
            CreateBeing(enemyPrefab, new Vector2Int(5, 8));
        }
        private void CreateBeing(Being beingPrefab, Vector2Int position)
        {
            Being beingInstance = Instantiate(beingPrefab, beingContainer);
            beingInstance.transform.localPosition = position.ToVector3();

            beingByPosition[position] = beingInstance;
        }

    }
}