using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabs;
    [SerializeField] private GameObject[] spawnPoints;
    [SerializeField] private Vector2 spawnRange;

    private int _minTimeToSpawn;
    private int _maxTimeToSpawn;

    private bool gameOver;

    void Start()
    {
        gameOver = false;

        _minTimeToSpawn = (int)spawnRange.x;
        _maxTimeToSpawn = (int)spawnRange.y;

        StartCoroutine(SpawnCoroutine());
    }

    private IEnumerator SpawnCoroutine()
    {
        while (!gameOver)
        {
            int randomTime = Random.Range(_minTimeToSpawn, _maxTimeToSpawn);
            yield return new WaitForSeconds(randomTime);

            SpawnPrefab();
        }

    }

    private void SpawnPrefab()
    {
        int randomIndex = Random.Range(0, prefabs.Length);
        GameObject prefab = prefabs[randomIndex];
        int randomPoint = Random.Range(0, spawnPoints.Length);
        Vector3 tempVector = spawnPoints[randomPoint].transform.position;
        Instantiate(prefab, tempVector /*transform.position*/, Quaternion.identity);
    }
}
