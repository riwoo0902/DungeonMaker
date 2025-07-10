using System;
using System.Collections.Generic;
using UnityEngine;


namespace Lrw_Manager
{
    [Serializable]
    public class TileTypeData
    {
        [field: SerializeField] public Sprite tileTypeSprite { get; private set; }
        [field: SerializeField] public List<LrwTileData> tileDatas { get; private set; }
    }
}

