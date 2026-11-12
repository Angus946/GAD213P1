using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScript : MonoBehaviour
{
    public GameObject Timer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //test

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Timer.SetActive(false);
            Timer.SetActive(true);
        }
    }
}
