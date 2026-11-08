using UnityEngine;
using TMPro;

public class PickBoostScript : MonoBehaviour
{
    public TMP_Text m_Text;
    private BoostBaseScript BoostBaseScript;
    public SpeedBoostScript SpeedBoostScript;
    public JumpBoostScript JumpBoostScript;
    public ControlBoostScript ControlBoostScript;

    public bool boostHeld;
    public string[] boostTypes;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boostTypes = new string[3];
        boostTypes[0] = "speed";
        boostTypes[1] = "jump";
        boostTypes[2] = "control";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " hit");
        if (other.CompareTag("BoostItem"))
        {
            Debug.Log("boost item collected");
            PickBoostFunc();
            boostHeld = true;
        }
    }

    //sadn't

    private void PickBoostFunc()
    {
        for (int i = 0; i< 1; i++)
        {
            int pickBoost = Random.Range(0, boostTypes.Length);
            Debug.Log($"{boostTypes[pickBoost]}");

            if (boostTypes[pickBoost] != null)
            {
                if (boostTypes[pickBoost] == "speed")
                {
                    Debug.Log("speed boost chosen");
                    SpeedBoostScript.enabled = true;
                    JumpBoostScript.enabled = false;
                    ControlBoostScript.enabled = false;
                    m_Text.text = "Boost Available: Speed";
                    return;
                }
                if (boostTypes[pickBoost] == "jump")
                {
                    Debug.Log("jump boost chosen");
                    JumpBoostScript.enabled = true;
                    SpeedBoostScript.enabled = false;
                    ControlBoostScript.enabled = false;
                    m_Text.text = "Boost Available: Jump";
                    return;
                }
                if (boostTypes[pickBoost] == "control")
                {
                    Debug.Log("control boost chosen");
                    ControlBoostScript.enabled = true;
                    SpeedBoostScript.enabled = false;
                    JumpBoostScript.enabled = false;
                    m_Text.text = "Boost Available: Control";
                    return;
                }
                
            }
        }
        
    }
}
