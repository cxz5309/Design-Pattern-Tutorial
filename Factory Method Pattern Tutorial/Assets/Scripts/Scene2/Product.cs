using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Database
{
    public string name;
    public double rows;

    public abstract void ConnectDatabase();

    public void InsertData()
    {
        Debug.Log(name + " 에 데이터를 추가했습니다");
    }
    public void SelectDate()
    {
        Debug.Log(name + " 에서 데이터를 " + rows + "개 조회했습니다.");
    }
}

public class MySQL : Database
{
    public MySQL()
    {
        name = "MySQL";
        rows = 20;
    }

    public override void ConnectDatabase()
    {
        Debug.Log(name + " 에 접속했습니다..");
    }
}


public class Oracle : Database
{
    public Oracle()
    {
        name = "Oracle";
        rows = 10;
    }

    public override void ConnectDatabase()
    {
        Debug.Log(name + " 에 접속했습니다..");
    }
}

public class Informix : Database
{
    public Informix()
    {
        name = "Informix";
        rows = 40;
    }

    public override void ConnectDatabase()
    {
        Debug.Log(name + " 에 접속했습니다..");
    }
}

