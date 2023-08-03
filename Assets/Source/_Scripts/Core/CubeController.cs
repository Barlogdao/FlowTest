
using UnityEngine;

namespace Test.Core
{
    [RequireComponent(typeof(Rigidbody))]
    public class CubeController : MonoBehaviour
    {
        private Rigidbody _rb;


        [SerializeField] private float _rotationSpeed;
        [SerializeField] private float _speed = 5;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            MoveForward();

        }
        private void FixedUpdate()
        {
            Rotate();
        }

        private void MoveForward()
        {


            if (Input.GetKeyDown(KeyCode.W))
            {
                _rb.AddForce(transform.forward * _speed, ForceMode.Impulse);
                

            }
        }
        private void Rotate()
        {
            var h = Input.GetAxis("Horizontal") * _rotationSpeed;
            if(h != 0)
            _rb.AddRelativeTorque(new Vector3(0f,h,0f), ForceMode.Impulse);
        }
    } 
}
