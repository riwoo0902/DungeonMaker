using System;
using UnityEngine;
using UnityEngine.Tilemaps;


namespace Lrw_Mouse
{
    [Serializable]
    public class ClickData
    {
        [field: SerializeField] public Vector3Int pos { get; private set; }
        [field: SerializeField] public Tilemap tileMap { get; private set; }

        public ClickData(Vector3Int GetTilemap, Tilemap getTile)
        {
            pos = GetTilemap;
            tileMap = getTile;
        }

    }
}

