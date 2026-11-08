using UnityEngine;

public class SpeedBoostScript : BoostBaseScript
{
    public float boostForce = 20f;

    protected override void Start()
    {
        base.Start();
        Debug.Log("Speed boost ready");
    }
    protected override void BoostFunc()
    {
        base.BoostFunc();
        Debug.Log("Speed boost Activated");
        base.rb.AddForce(rb.transform.forward * boostForce, ForceMode.Impulse);
    }
}
