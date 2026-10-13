using UnityEngine;
using TMPro;
using rayzngames;

public class SpeedometerScript : MonoBehaviour
{

    public TMP_Text m_Text;

    public BicycleVehicle m_Vehicle;

    public float m_Speed;
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
    }
}
