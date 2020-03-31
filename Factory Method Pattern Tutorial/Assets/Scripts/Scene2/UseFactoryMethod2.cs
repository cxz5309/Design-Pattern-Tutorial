using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseFactoryMethod2 : MonoBehaviour
{
    DatabaseFactory factory = null;
    Database db = null;
    
    private void Start()
    {
        factory = GetComponent<DatabaseGenerator>();

        db = factory.MakeDatbase();

        db.ConnectDatabase();

        db.InsertData();
        db.SelectDate();
    }
}
