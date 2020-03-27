using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    float speed = 10f;

    private void Update()
    {
        this.transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (this.transform.position.y > 10.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
