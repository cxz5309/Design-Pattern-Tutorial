using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolContainer : MonoBehaviour
{
    private static ObjectPoolContainer instance;

    public static ObjectPoolContainer Instance {
        get
        {
            if (instance == null)
            {
                GameObject obj = new GameObject("ObjectPoolContainer");
                instance = obj.AddComponent<ObjectPoolContainer>();
            }
            return instance;
        }
    }

    Dictionary<string, Queue<GameObject>> objectPoolDic = new Dictionary<string, Queue<GameObject>>();

    public void InitObjectPool(string poolingName, GameObject obj, int createCount)
    {
        Queue<GameObject> poolQueue = new Queue<GameObject>();
        for(int i = 0; i < createCount; i++)
        {
            GameObject clone = Instantiate(obj, this.transform);
            clone.name = poolingName;
            if(clone.activeSelf == true)
            {
                clone.SetActive(false);
            }
            poolQueue.Enqueue(clone);
        }
        objectPoolDic.Add(poolingName, poolQueue);
        Debug.Log("남은 오브젝트 숫자 : " + poolingName + objectPoolDic[poolingName].Count);
    }

    public GameObject PopObjectPool(string poolingName)
    {
        if (objectPoolDic[poolingName].Count == 1)
        {
            GameObject clone = Instantiate(objectPoolDic[poolingName].Peek(), this.transform);
            clone.name = poolingName;
            if (clone.activeSelf == true)
            {
                clone.SetActive(false);
            }
            objectPoolDic[poolingName].Enqueue(clone);
            Debug.LogError("오브젝트풀 카운트 초과 : " + poolingName);
        }

        GameObject returnObj = objectPoolDic[poolingName].Dequeue();
        returnObj.SetActive(true);
        Debug.Log("남은 오브젝트 숫자 : " + poolingName + objectPoolDic[poolingName].Count);
        return returnObj;
    }

    public GameObject PopObjectPool(string poolingName, Vector3 newPosition)
    {
        if (objectPoolDic[poolingName].Count == 1)
        {
            GameObject clone = Instantiate(objectPoolDic[poolingName].Peek(), this.transform);
            clone.name = poolingName;
            objectPoolDic[poolingName].Enqueue(clone);
            Debug.LogError("오브젝트풀 카운트 초과 : " + poolingName);
        }

        GameObject returnObj = objectPoolDic[poolingName].Dequeue();
        returnObj.transform.position = newPosition;
        returnObj.SetActive(true);
        Debug.Log("남은 오브젝트 숫자 : " + poolingName + objectPoolDic[poolingName].Count);
        return returnObj;
    }

    public void ReturnObjectPool(GameObject obj)
    {
        if (objectPoolDic.ContainsKey(obj.name))
        {
            obj.SetActive(false);
            objectPoolDic[obj.name].Enqueue(obj);
            Debug.Log("남은 오브젝트 숫자 : " + obj.name + objectPoolDic[obj.name].Count);
        }
    }

    private void OnDestroy()
    {
        instance = null;
    }


}
