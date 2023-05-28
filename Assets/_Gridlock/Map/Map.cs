using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gridlock
{
    public class Map : Factory<Tile>
    {
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
                    Tile tile = InstantiatePrefabAtPosition(x, z);

                    tile.gameObject.name = $"Tile ({x},{z})";
                }
            }
        }
    }
}
