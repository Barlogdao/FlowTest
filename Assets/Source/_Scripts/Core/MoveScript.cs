using UnityEngine;


namespace Test.Moving
{
    public class MoveScript : MonoBehaviour
    {
        [SerializeField]
        private float rotationSpeed = 10f;
        private void Update()
        {
            transform.Rotate(rotationSpeed * Time.deltaTime, 0f, 0f);
        }
    }
}
