using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private void Start()
    {
        this.GetComponent<Rigidbody>().AddForce(Vector3.down*100);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Wall")
        {
            ObjectPoolContainer.Instance.ReturnObjectPool(this.gameObject);
        }
    }
}
