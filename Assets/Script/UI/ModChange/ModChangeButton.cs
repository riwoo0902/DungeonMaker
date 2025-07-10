using UnityEngine;
using UnityEngine.UI;


namespace Lrw_UI
{
    public class ModChangeButton : MonoBehaviour
    {
        [SerializeField] private Sprite[] sprites = new Sprite[2];
        Image Image;


        public void ChangeSprite()
        {
            Image = transform.GetChild(0).GetComponent<Image>();
            Image.sprite = Image.sprite == sprites[1] ? sprites[0] : sprites[1];
        }



    }
}

