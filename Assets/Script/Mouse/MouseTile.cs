using System.Collections.Generic;
using System.Linq;
using Lrw_Manager;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;


namespace Lrw_Mouse
{
    public class MouseTile : MonoBehaviour
    {
        [field:SerializeField] public LrwTileData tileData { get; private set; }
        [field: SerializeField] public int MouseMod = 1;
        //0은 설치 불가
        //1은 일반 그리기
        //2는 드래그로 그리기
        //3은 지우개
        //4는 드래그로 지우기

        private Dictionary<int, ClickData> tileSetDictionary = new();
        private int tileSetDictionaryCount = 0;

        public static MouseTile instance;


        private void Awake()
        {

            if (instance == null) instance = this;
            else Destroy(gameObject);
        }


        private void Update()
        {
            if (Mouse.current.leftButton.isPressed)
            {
                if(MouseMod == 1)
                {
                    if (!tileSetDictionary.Values.Any(v => v.pos == MouseMove.mousePos))
                    {
                        tileData.tilemap.SetTile(MouseMove.mousePos, tileData.tile);
                        tileSetDictionary.Add(tileSetDictionaryCount++, new ClickData(MouseMove.mousePos, tileData.tilemap, tileData.tile));

                    }
                }
                else if (MouseMod == 2)
                {

                }
                else if (MouseMod == 3)
                {

                }
                else if (MouseMod == 4)
                {

                }
                else
                {
                    Debug.Log("Error");
                }



            }

            if (Keyboard.current.zKey.wasPressedThisFrame)
            {
                if (tileSetDictionaryCount > 0)
                {
                    ClickData a = tileSetDictionary[--tileSetDictionaryCount];
                    a.tileMap.SetTile(a.pos, null);
                    tileSetDictionary.Remove(tileSetDictionaryCount);
                }
                
            }


            
        }


        public void SetTileAndTileMap(LrwTileData td)
        {
            tileData = td;
        }



    }
}

