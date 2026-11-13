using rayzngames;
using UnityEngine;

public class ControlBoostScript : BoostBaseScript
{
    public BicycleVehicle Bike;


    protected override void Start()
    {
        base.Start();
        Bike.slideCoefficient = 1.1f;
        Debug.Log("Control boost ready");
    }
    //doot

    protected override void BoostFunc()
    {
        base.BoostFunc();
        Debug.Log("Control boosted");
        BoostTime = 6f;
        Bike.slideCoefficient = 11f;
        StartCoroutine("BoostTimer");
    }

    protected override void StopBoost()
    {
        base.StopBoost();
        Bike.slideCoefficient = 1.1f;
    }
}
