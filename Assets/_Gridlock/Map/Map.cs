using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gridlock
{
    public class Map : MonoBehaviour
    {
        [SerializeField]
        private Tile tilePrefab;

        [SerializeField]
        private Transform tilesContainer;

        [SerializeField]
        private int sizeX;

        [SerializeField]
        private int sizeZ;

        private void Start()
        {
            CreateMap();
        }
        private void CreateMap()
        {
            for(int x = 0; x < sizeX; x++)
            {
                for(int z = 0; z < sizeZ;z++)
                {
                    Tile tile = Instantiate(tilePrefab, new Vector3(x,0,z), Quaternion.identity, tilesContainer);
                    tile.gameObject.name = $"Tile ({x},{z})";
                }
            }
        }

    }

}
