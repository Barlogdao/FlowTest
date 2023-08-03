
using UnityEngine;


public class CameraControl : MonoBehaviour
{
    [SerializeField] Transform _player;
  



    private void LateUpdate()
    {
        transform.LookAt(_player.position);
    }

}
