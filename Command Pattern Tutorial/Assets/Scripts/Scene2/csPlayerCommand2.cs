using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csPlayerCommand2 : MonoBehaviour
{
    CommandKey2 btnA, btnB;

    private void Start()
    {
        SetCommand();
    }

    void SetCommand()
    {
        btnA = new CommandAttack2();
        btnB = new CommandDefense2();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            BtnCommandA();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            BtnCommandB();
        }
    }

    public void BtnCommandA()
    {
        btnA.Execute(gameObject);
    }
    public void BtnCommandB()
    {
        btnB.Execute(gameObject);
    }
}
