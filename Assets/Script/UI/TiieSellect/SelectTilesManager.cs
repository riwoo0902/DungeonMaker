using System.Collections.Generic;
using Lrw_Manager;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

namespace Lrw_UI
{
    public class SelectTilesManager : MonoBehaviour
    {
        [SerializeField] private GameObject imageUIPrefabs;

        private List<GameObject> blockTypeGameObject = new();
        public static SelectTilesManager instance { get; private set; }

        private void Awake()
        {
            if (instance != null) Destroy(gameObject);
            else instance = this;


        }


        private void Start()
        {
            try
            {
                for (int i = 0; i < TilesManager.instance.tileTypeDatas.Count; i++)
                {
                    GameObject emptyGameObject = transform.GetChild(i).gameObject;
                    blockTypeGameObject.Add(emptyGameObject);
                    for (int j = 0; j < TilesManager.instance.tileTypeDatas[i].tileDatas.Count; j++)
                    {
                        GameObject instantiateObject = emptyGameObject.transform.GetChild(j).gameObject;
                        instantiateObject.GetComponent<Image>().sprite = TilesManager.instance.tileTypeDatas[i].tileDatas[j].GetTileSprite();
                    }
                    emptyGameObject.SetActive(false);
                }

                setShowTiles(0);
            }
            catch
            {
                Debug.Log("tileSpriteObject ∫Œ¡∑");
            }
        }


        public void setShowTiles(int a)
        {
            for(int i = 0; i < blockTypeGameObject.Count; i++)
            {
                blockTypeGameObject[i].SetActive(i == a ? true : false);
            }
        }


        [ContextMenu("SetNoShowTiles")]
        public void SetNoShowTiles()
        {
            foreach(GameObject a in blockTypeGameObject)
            {
                a.SetActive(false);
            }
        }



        



        
    }
}

