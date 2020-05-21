using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorsPool : MonoBehaviour
{
    public static FloorsPool pool;

    public float spawnRate = 1;
    public int floorPoolSize = 5;
    public float floorXMin = -5f;
    public float floorXmax = 6f;

    private float timeSinceSwawn;
    private float spawnY = -5f;
    private int currentFloor = 0;
    public float spawnX;

    public GameObject floorSpawning;
    private GameObject[] floors;
    private Vector2 spawnPosition = new Vector2(-0.5f, 0.1f);

    void Start()
    {
        floors = new GameObject[floorPoolSize];
        for(int i = 0; i < floorPoolSize; i++)
        {
            floors[i] = (GameObject)Instantiate(floorSpawning, spawnPosition, Quaternion.identity);

        }   
    }

    
    void Update()
    {
        timeSinceSwawn += Time.deltaTime;
        if(!GameController.Instance.isGameOver && timeSinceSwawn >= spawnRate)
        {
            timeSinceSwawn = 0;

            spawnX = Random.Range(floorXMin, floorXmax);
            
            floors[currentFloor].transform.position = new Vector2(spawnX, spawnY);

            currentFloor++;
            if (currentFloor >= floorPoolSize)
            {
                currentFloor = 0;
            }
        }
        
    }

    
}
