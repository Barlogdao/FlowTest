using UnityEngine;


namespace Test.Core
{

    public class MoveScript : MonoBehaviour
    {
        [SerializeField]
        private float rotationSpeed = 10f;

        Material _material;
        private void Awake()
        {
            _material = GetComponent<MeshRenderer>().material;
        }

        private void Update()
        {
            transform.Rotate(rotationSpeed * Time.deltaTime, 0f, 0f);
        }
    }
}
