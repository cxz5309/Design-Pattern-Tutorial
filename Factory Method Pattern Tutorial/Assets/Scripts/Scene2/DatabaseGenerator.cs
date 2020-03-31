using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseGenerator : DatabaseFactory
{
    public DBType dbType = DBType.MySQL;

    public override Database MakeDatbase()
    {
        if(dbType== DBType.MySQL)
        {
            Debug.Log("MySQL use...");
            return new MySQL();
        }
        else if (dbType == DBType.Oracle)
        {
            Debug.Log("Oracle use...");
            return new Oracle();
        }
        else if (dbType == DBType.Informix)
        {
            Debug.Log("Informix use...");
            return new Informix();
        }
        else
        {
            return null;
        }
    }
}
