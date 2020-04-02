using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteSubject : MonoBehaviour
    //, ISubject
{
    //List<Observer> observers = new List<Observer>();
    private int myNum;

    delegate void NotiHandler(int num);
    NotiHandler _notiHandler;

    //public void AddObserver(Observer observer)
    //{
    //    observers.Add(observer);
    //}

    //public void RemoveObserver(Observer observer)
    //{
    //    if (observers.IndexOf(observer) > 0) observers.Remove(observer);
    //}

    public void Notify()
    {
        //foreach(Observer o in observers)
        //{
        //    o.OnNotify(myNum);
        //}
        _notiHandler(myNum);
    }

    public int getNum()
    {
        return myNum;
    }

    private void Start()
    {
        myNum = 10;

        Observer obj1 = new ConcreteObserver1(this.gameObject);
        Observer obj2 = new ConcreteObserver2(this.gameObject);

        //AddObserver(obj1);
        //AddObserver(obj2);

        _notiHandler += new NotiHandler(obj1.OnNotify);
        _notiHandler += new NotiHandler(obj2.OnNotify);
    }
}
