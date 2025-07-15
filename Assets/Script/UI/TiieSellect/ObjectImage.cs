using UnityEngine;
using UnityEngine.UI;

namespace Lrw_UI
{
    public class ObjectImage
    {
        public GameObject gameObject { get; private set; }
        public Image image { get; private set; }

        public void setGameObject(GameObject a)
        {
            gameObject = a;
        }
        public void setImage(Image a)
        {
            image = a;
        }


    }
}
