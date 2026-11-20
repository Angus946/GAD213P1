using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;

public class GoalScript : MonoBehaviour
{
    public int goalsHit;
    public bool goalScored;
    public TMP_Text text;
    public GoalSpawnScript GoalSpawn;
    public bool randomSpawn = true;
    private int goals;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1.0f;
        text.text = "Zones Reached: 0";
        GoalSpawn.GetComponent<GoalSpawnScript>();
        if (!GoalSpawn.isActiveAndEnabled )
        {
            Debug.Log("Goal Spawn Script is inactive");
            randomSpawn = false;
            goals = 4;
        }

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
        text.text = "Zones Reached: " + goalsHit.ToString();
        if (!randomSpawn)
        {
            if (goalsHit >= goals)
            {
                Time.timeScale = 0.0000001f;
            }
        }
        if (goalsHit >= GoalSpawn.n_Goals)
        {
            Time.timeScale = 0.0000001f;
        }
    }

    
}
