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
                if (!tileSetDictionary.Values.Any(v => v.pos == MouseMove.mousePos))
                {
                    tileData.tilemap.SetTile(MouseMove.mousePos, tileData.tile);
                    tileSetDictionary.Add(tileSetDictionaryCount++, new ClickData(MouseMove.mousePos, tileData.tilemap));

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

