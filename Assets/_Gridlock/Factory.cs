using System.Collections.Generic;
using UnityEngine;

namespace Gridlock{
	public class Factory<T> : MonoBehaviour where T : MonoBehaviour
	{
        private Dictionary<Vector2Int, T> instanceByPosition = new();

        [SerializeField]
        private T prefab;

        [SerializeField]
        private Transform container;

        protected T InstantiatePrefabAtPosition(Vector2Int position)
        {
            var instance = Instantiate(prefab, new Vector3(position.x, 0, position.y), Quaternion.identity, container);
            instanceByPosition[position] = instance;
            return instance;
        }
        protected T InstantiatePrefabAtPosition(int xPosition, int zPosition)
        {
            return InstantiatePrefabAtPosition(new Vector2Int(xPosition, zPosition));
        }

    }
}