using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float spawnZPostion = 15f;
    [SerializeField] private float xRange = 15f;
    [SerializeField] private float initialSpawnDelay = 5f;
    [SerializeField] private float spawnInterval = 10f;
    [SerializeField] private List<GameObject> animals;

    private void Start()
    {
        InvokeRepeating("SpawnAnimal", initialSpawnDelay, spawnInterval);
    }

    private void SpawnAnimal()
    {
        GameObject randomAnimal = animals[Random.Range(0, animals.Count)];
        Vector3 spawnPosition = new Vector3(Random.Range(-xRange, xRange), 0f, spawnZPostion);
        Instantiate(randomAnimal, spawnPosition, transform.rotation);
    }

}
