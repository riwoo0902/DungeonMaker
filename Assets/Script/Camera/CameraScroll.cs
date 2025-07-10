using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Lrw_Camera
{
    public class CameraScroll : MonoBehaviour
    {
        new CinemachineCamera camera;
        public float scrollSpeed = 1;

        private void Awake()
        {
            camera = GetComponent<CinemachineCamera>();
        }

        void Update()
        {
            float y = -Mouse.current.scroll.ReadValue().y;
            camera.Lens.OrthographicSize += y * scrollSpeed;




        }
    }

}
