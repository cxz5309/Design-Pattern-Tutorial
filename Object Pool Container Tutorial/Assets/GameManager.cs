using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject CubePrefab;

    private void Awake()
    {
        ObjectPoolContainer.Instance.InitObjectPool("Cube", CubePrefab, 10);
    }

    private void Start()
    {
        StartCoroutine(CoCubeMake());
    }

    IEnumerator CoCubeMake()
    {
        for(int i = 0; i < 100; i++)
        {
            GameObject cube = ObjectPoolContainer.Instance.PopObjectPool("Cube", new Vector3(Random.Range(-5, 5), Random.Range(-2, 10), 0));
            yield return new WaitForSeconds(0.4f);
        }
    }
}
