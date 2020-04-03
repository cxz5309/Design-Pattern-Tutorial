using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCannon : MonoBehaviour
{
    float power = 900f;
    Vector3 velocity;

    private void Start()
    {
        velocity = transform.forward * power;
        GetComponent<Rigidbody>().AddForce(velocity);
        StartCoroutine(DeleteCannon());

        IEnumerator DeleteCannon()
        {
            yield return new WaitForSeconds(0.5f);
            Destroy(this.gameObject);
        }
    }
}


