using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class csPlayerCommand : MonoBehaviour
{
    public GameObject shield;
    public GameObject cannon;
    public Transform firePos;
    bool bCmd;
    Text txt1;
    Text txt2;

    CommandKey btnA, btnB;

    private void Start()
    {
        bCmd = true;
        txt1 = GameObject.Find("Text1").GetComponent<Text>();
        txt2 = GameObject.Find("Text2").GetComponent<Text>();

        SetCommand();
    }

    public void SetCommand()
    {
        if(bCmd == true)
        {
            btnA = new CommandAttack(this, shield, cannon, firePos);
            btnB = new CommandDefense(this, shield, cannon, firePos);

            bCmd = false;
            txt1.text = "A - Attack";
            txt2.text = "B - Defense";
        }
        else
        {
            btnA = new CommandDefense(this, shield, cannon, firePos);
            btnB = new CommandAttack(this, shield, cannon, firePos);

            bCmd = true;
            txt1.text = "A - Defense";
            txt2.text = "B - Attack";
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            btnA.Execute();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            btnB.Execute();
        }
    }
}
