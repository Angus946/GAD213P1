using UnityEngine;

public class JumpBoostScript :  BoostBaseScript
{
    public float boostForce = 20f;

    protected override void Start()
    {
        base.Start();
        Debug.Log("jump boost ready");
    }
    protected override void BoostFunc()
    {
        base.BoostFunc();
        Debug.Log("Speed boost Activated");
        base.rb.AddForce(Vector3.up * boostForce, ForceMode.Impulse);
    }

}
