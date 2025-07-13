using System;
using UnityEngine;
using UnityEngine.Tilemaps;


namespace Lrw_Mouse
{
    public class ClickData
    {
        public Vector3Int pos { get; private set; }
        public Tilemap tileMap { get; private set; }
        public TileBase tile { get; private set; }

        public ClickData(Vector3Int getTilemap, Tilemap getTile, TileBase gettile)
        {
            pos = getTilemap;
            tileMap = getTile;
            tile = gettile;
        }

    }
}

