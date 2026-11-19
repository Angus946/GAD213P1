using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public int goalsHit;
    public bool goalScored;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goal"))
        {
            if (goalScored) { return; }
            goalScored = true;
            Debug.Log("goal hit");
            other.gameObject.SetActive(false);
            Score();
            StartCoroutine(BoolDelay());
        }
    }
    IEnumerator BoolDelay()
    {
        yield return new WaitForSeconds(.1f);
        goalScored = false;
    }

    void Score()
    {
        goalsHit++;
        if (goalsHit >= 3)
        {
            Time.timeScale = 0.0000001f;
        }
    }

    
}
