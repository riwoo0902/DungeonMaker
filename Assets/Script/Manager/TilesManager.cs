using System;
using System.Collections.Generic;
using UnityEngine;


namespace Lrw_Manager
{
    public class TilesManager : MonoBehaviour
    {
        [field: SerializeField] public List<TileTypeData> tileTypeDatas { get; private set; }
        private int tileTypeCount;


        public static TilesManager instance { get; private set; }
        private void Awake()
        {
            if (instance != null) Destroy(gameObject);
            else instance = this;

            tileTypeCount = tileTypeDatas.Count;
        }

        private void Update()
        {


            //if (tile is Tile tileData)
            //{
            //    return tileData.sprite; // �Ϲ� Ÿ��(Tile)�� ���
            //}
            //else if (tile is RuleTile ruleTile)
            //{
            //    // RuleTile�� ���ǿ� ���� ���� ��������Ʈ�� ���� �� ����
            //    // �⺻���� ��� ���� ���, m_TilingRules[0]�� �����ϰų� ���� �ľ��ؾ� ��
            //    if (ruleTile.m_TilingRules != null && ruleTile.m_TilingRules.Count > 0)
            //    {
            //        return ruleTile.m_TilingRules[0].m_Sprites[0]; // ù ��° ���� ù ��������Ʈ
            //    }
            //}




        }

    }
}

