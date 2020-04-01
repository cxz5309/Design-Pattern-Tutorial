using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderUse : MonoBehaviour
{
    private void Start()
    {
        Engineer engineer = new Engineer();

        CarBuilder carBuilder = GetComponent<CarBuilder>();
        carBuilder.makeVehicle();

        MotorCycleBuilder motorCycleBuilder = GetComponent<MotorCycleBuilder>();
        motorCycleBuilder.makeVehicle();

        engineer.Construct(carBuilder);
        engineer.Construct(motorCycleBuilder);

        Vehicle car = carBuilder.getVehicle();
        Debug.Log(car.GetPartsList());

        Vehicle motorCycle = motorCycleBuilder.getVehicle();
        Debug.Log(motorCycle.GetPartsList());

        car.transform.position = new Vector3(-3f, 0, 0);
        motorCycle.transform.position = new Vector3(3f, 0, 0);
    }
}
