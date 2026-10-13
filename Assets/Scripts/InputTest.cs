using UnityEngine;

public class InputTest : MonoBehaviour
{
    public float HorizontalInput { get; set; }
    public float VerticalInput { get; set; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VerticalInput = Input.GetAxis("Vertical");
        HorizontalInput = Input.GetAxis("Horizontal");
        Debug.Log(HorizontalInput.ToString());
        Debug.Log(VerticalInput.ToString());

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space Pressed");
        }
    }
}
