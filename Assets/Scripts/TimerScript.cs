using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{

    public TMP_Text TimerText;

    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        TimerText.text = timer.ToString("F3");
    }
}
