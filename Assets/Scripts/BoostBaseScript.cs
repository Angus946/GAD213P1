using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using TMPro;

public class BoostBaseScript : MonoBehaviour
{
    protected bool boostHeld;
   

    protected bool boostActive = false;
    protected bool boostDisabled = false;
    protected float BoostTime;
    protected Rigidbody rb;

    public PickBoostScript boostScript;
    public SpeedBoostScript speedBoostScript;
    public JumpBoostScript jumpBoostScript;
    public ControlBoostScript controlBoostScript;
    public TMP_Text TextBox;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        BoostInput();
        boostHeld = boostScript.boostHeld;
    }

    protected void BoostInput()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            BoostTestFunc();
        }
    }

    protected virtual void BoostTestFunc()
    {
        if (boostHeld)
        {
            boostActive = true;
            boostHeld = false;
            Debug.Log("Boost Activated");
            BoostFunc();
            StartCoroutine("BoostTimer");
        }
        else
        {
            Debug.Log("no Boost :(");
        }
       
    }

    protected virtual void BoostFunc()
    {

    }

    protected IEnumerator BoostTimer()
    {
        yield return new WaitForSeconds(BoostTime);
        StopBoost();
    }
    protected virtual void StopBoost()
    {
        boostActive = false;
        boostHeld = false;
        Debug.Log("Boost Stopped");
        speedBoostScript.enabled = false;
        jumpBoostScript.enabled = false;
        controlBoostScript.enabled = false;
        TextBox.text = "Boost Available: none";
    }
}
