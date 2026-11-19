using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using TMPro;
using UnityEngine.UI;

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
    public GameObject SpeedBoostIcon;
    public GameObject JumpBoostIcon;
    public GameObject ControlBoostIcon;
    public Image SpeedBoostIconImage;
    public Image JumpBoostIconImage;
    public Image ControlBoostIconImage;
    


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
        SpeedBoostIconImage.color = Color.black;
        JumpBoostIconImage.color = Color.black;
        ControlBoostIconImage.color = Color.black;
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
        SpeedBoostIcon.transform.position = new Vector3(0, -300, 0);
        JumpBoostIcon.transform.position = new Vector3(0, -300, 0);
        ControlBoostIcon.transform.position = new Vector3(0, -300, 0);
        TextBox.text = "Boost Available: none";
    }
}
