using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Lrw_Manager
{
    [Serializable]
    public class LrwTileData
    {
        [field: SerializeField] public Tilemap tilemap { get; private set; }
        [field: SerializeField] public TileBase tile { get; private set; }
        
        public Sprite GetTileSprite()
        {
            if (tile is Tile tileData)
            {
                return tileData.sprite; // �Ϲ� Ÿ��(Tile)�� ���
            }
            else if (tile is RuleTile ruleTile)
            {

                return ruleTile.m_DefaultSprite;
            }

            Debug.Log("Ÿ�Ͽ��� sprite �� �޾���!!!");
            return null;


        }


    }
}

