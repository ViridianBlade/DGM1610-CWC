﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    
    private float spawnInterval;
    private int ballIndex;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(SpawnRandomBall());
    }

    // Spawn random ball at random x position at top of play area
    IEnumerator SpawnRandomBall ()
    {
        while (true)
        {
            spawnInterval = Random.Range(3,5);
            yield return new WaitForSeconds(spawnInterval);

            // Generate random ball index and random spawn position
            ballIndex = Random.Range(0,ballPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        
            // instantiate ball at random spawn location
            Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        }
        
    }

}
