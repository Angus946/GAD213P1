using NUnit.Framework;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class GoalSpawnScript : MonoBehaviour
{
    [SerializeField]
    private GameObject GoalZone;

    private int num_GoalZones;
    public int n_Goals;

    [SerializeField]
    List<GameObject> goalZones;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goalZones = new List<GameObject>();
        num_GoalZones = Random.Range(2, 5);
        for (int i = 0; i < num_GoalZones; i++)
        {
            float posX = Random.Range(-80, 80);
            float posZ = Random.Range(-160, 0);
            Vector3 Pos = new Vector3(posX, 20, posZ);
            Instantiate(GoalZone, Pos, Quaternion.identity);
            goalZones.Add(GoalZone);
            n_Goals = goalZones.Count;
            Debug.Log("number of Goals " + n_Goals);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
