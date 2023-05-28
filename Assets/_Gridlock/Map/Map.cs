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

        private Dictionary<Vector2Int, Tile> tileByPosition = new();


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
                    Vector2Int position = new Vector2Int(x, z);

                    Tile tile = Instantiate(tilePrefab, tilesContainer);
                    tile.transform.localPosition = position.ToVector3();

                    tileByPosition[position] = tile;

                    tile.gameObject.name = $"Tile ({x},{z})";
                }
            }
        }

    }

}
