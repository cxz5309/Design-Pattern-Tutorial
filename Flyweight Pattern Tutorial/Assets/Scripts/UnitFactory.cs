using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactory : MonoBehaviour
{
    Dictionary<string, GameObject> dic = new Dictionary<string, GameObject>();
    public GameObject marine;
    public GameObject getMarine(string name)
    {
        if (!dic.ContainsKey(name))
        {
            float x = (float)Random.Range(-10, 11);
            float y = (float)Random.Range(-10, 11);
            Vector3 pos = new Vector3(x, y, 1.0f);

            GameObject obj = Instantiate(marine, pos, Quaternion.identity);
            obj.GetComponent<Marine>().setName(name);
            dic.Add(name, obj);
        }
        return dic[name];
    }
}
