using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public Text waveTimer;
    public float timeBetweenWaves = 5.5f;

    private float countDown = 2f;
    private int waveIndex = 0;
    
    void Update()
    {
        waveTimer.text = $"Next wave: {Math.Round(countDown)} seconds";
        if (countDown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countDown = timeBetweenWaves;
        }        
        countDown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
        for (int i = 0; i <= waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.2f);
        }
        waveIndex++;
    }

    void SpawnEnemy()
    {        
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

}
