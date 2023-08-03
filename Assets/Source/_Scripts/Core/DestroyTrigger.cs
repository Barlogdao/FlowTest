using UnityEngine;

namespace Test.Core
{
    public class DestroyTrigger : MonoBehaviour
    {
        Material _material;
        private void Awake()
        {
            _material = GetComponent<MeshRenderer>().material;
        }


        private void Start()
        {
            //material.color = Color.red;
        }
        private void OnMouseUpAsButton()
        {
            SignalBus.InvokeDestroySphere();
            Destroy(gameObject);
        }
    }

}