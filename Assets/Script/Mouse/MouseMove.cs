using UnityEngine;


namespace Lrw_Mouse
{
    public class MouseMove : MonoBehaviour
    {
        [field: SerializeField] public static Vector3Int mousePos { get; private set; }

        public static MouseMove instance;

        private void Awake()
        {
            if (instance == null) instance = this;
            else Destroy(gameObject);
        }
        private void Update()
        {
            Vector3 mousePosSave = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos = new Vector3Int((int)Mathf.Floor(mousePosSave.x), (int)Mathf.Floor(mousePosSave.y));







            transform.position = mousePos;
        }




    }
}

