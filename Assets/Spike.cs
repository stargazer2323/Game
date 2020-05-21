using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{

    public Spike spikeobj;

    public FloorsPool valueOfX ;
    public float spikesSpawnRate = 1;
    public int spikePoolSize = 5;
    public float spikeXmin = -7f;
    public float spikeXmax = 8f;
    public float timeofSpawn;
    public float spikeSpawnY = -4.2f;
    private int currentSpike = 0;
    public float spspawnX;
   

    public GameObject spikeSpawning;
    private GameObject[] spikes;
    private Vector2 spikeSpawnPosition = new Vector2(-1.86f, 0.95f);

    void Start()
    {
        spikes = new GameObject[spikePoolSize];
        for (int i = 0; i < spikePoolSize; i++)
        {
            spikes[i] = (GameObject)Instantiate(spikeSpawning, spikeSpawnPosition, Quaternion.identity);

        }

    }

    // Update is called once per frame
    void Update()
    {
        timeofSpawn += Time.deltaTime;
        if (!GameController.Instance.isGameOver && timeofSpawn >= spikesSpawnRate)
        {
            timeofSpawn = 0;

            spspawnX = UnityEngine.Random.Range(spikeXmin, spikeXmax);
            
            /*for (int i = 0; i < spikePoolSize; i++)
            {
                Debug.Log("hi"+i);

            }*/
            
            if (valueOfX.spawnX < spspawnX && valueOfX.spawnX + 2.5f > spspawnX)
            {
                spikes[currentSpike].transform.position = new Vector2(spspawnX + 10f, spikeSpawnY);
                //Debug.Log("Error");

            }
            else
            {
                spikes[currentSpike].transform.position = new Vector2(spspawnX, spikeSpawnY);

            }



            currentSpike++;

            if (currentSpike >= spikePoolSize)
            {
                currentSpike = 0;
            }
        }
            
               
            

        
        

        
    }

    

}
