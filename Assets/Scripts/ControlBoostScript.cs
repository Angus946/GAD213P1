using UnityEngine;

public class ControlBoostScript : BoostBaseScript
{
    public WheelFrictionCurve RearWheelCollider;


    protected override void Start()
    {
        base.Start();
        Debug.Log("Control boost ready");
    }
    //doot

    protected override void BoostFunc()
    {
        base.BoostFunc();
        Debug.Log("Control boosted");
        BoostTime = 6f;
        RearWheelCollider.extremumValue = 2000f;
        StartCoroutine("BoostTimer");
    }
}
