using System.Collections.Generic;
using Lrw_Manager;
using UnityEngine;
using UnityEngine.UI;

namespace Lrw_UI
{
    public class BlockTypeSprite : MonoBehaviour
    {

        private void Awake()
        {
            for(int i = 0;i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.GetComponent<Image>().sprite = TilesManager.instance.tileTypeDatas[i].tileTypeSprite;
            }



        }





    }

}
