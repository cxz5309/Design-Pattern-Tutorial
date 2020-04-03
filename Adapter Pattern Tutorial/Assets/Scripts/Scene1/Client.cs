using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    private void Start()
    {
        MallardDuck duck = new MallardDuck();
        WildTurkey turkey = new WildTurkey();
        Duck turkeyAdapter = new TurkeyAdapter(turkey);

        Debug.Log("오리 사용...");
        testDuck(duck);

        Debug.Log("칠면조로 대체...");
        testDuck(turkeyAdapter);

    }
    void testDuck(Duck duck)
    {
        duck.quack();
        duck.fly();
    }
}
