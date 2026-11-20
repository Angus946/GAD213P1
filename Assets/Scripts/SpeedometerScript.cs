using UnityEngine;
using TMPro;
using rayzngames;
using UnityEngine.UI;

public class SpeedometerScript : MonoBehaviour
{

    public TMP_Text m_Text;

    public BicycleVehicle m_Vehicle;

    public float m_Speed;

    public float percent_Dial;
    public float rotation_Dial;
    public Transform DialIcon;
    Quaternion Q_Rotaion;
    public float Speed 
    {
        get { return m_Vehicle.currentSpeed; }
        set { Speed = Mathf.RoundToInt(value); }
    } 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Vehicle = GetComponent<BicycleVehicle>();
    }

    // Update is called once per frame
    void Update()
    {
        m_Speed = Mathf.Round(Speed * 3.6f);
        //Debug.Log(Mathf.Round(Speed * 3.6f));
        m_Text.text = m_Speed.ToString();
        Dial();
    }

    void Dial()
    {
        percent_Dial = Mathf.Round((m_Speed / 200f) * 100f);
        Debug.Log("Dial percent = " +  percent_Dial);
        rotation_Dial = ((-percent_Dial * 1.8f) + 90f);
        Debug.Log("Dial rotation = " + rotation_Dial);
        Vector3 V_Rotation = new Vector3(0f, 0f, rotation_Dial);
        Q_Rotaion = Quaternion.Euler(V_Rotation);
        DialIcon.transform.rotation = Q_Rotaion;
    }
}
