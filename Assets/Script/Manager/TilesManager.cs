using System;
using System.Collections.Generic;
using UnityEngine;


namespace Lrw_Manager
{
    public class TilesManager : MonoBehaviour
    {
        [field: SerializeField] public List<TileTypeData> tileTypeDatas { get; private set; }
        private int tileTypeCount;

        private void Awake()
        {
            tileTypeCount = tileTypeDatas.Count;
        }

        private void Update()
        {


            //if (tile is Tile tileData)
            //{
            //    return tileData.sprite; // 일반 타일(Tile)의 경우
            //}
            //else if (tile is RuleTile ruleTile)
            //{
            //    // RuleTile은 조건에 따라 여러 스프라이트가 있을 수 있음
            //    // 기본값을 얻고 싶을 경우, m_TilingRules[0]을 참조하거나 룰을 파악해야 함
            //    if (ruleTile.m_TilingRules != null && ruleTile.m_TilingRules.Count > 0)
            //    {
            //        return ruleTile.m_TilingRules[0].m_Sprites[0]; // 첫 번째 룰의 첫 스프라이트
            //    }
            //}




        }

    }
}

