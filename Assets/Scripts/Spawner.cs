using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float minSpawnDelay;
    [SerializeField] float maxSpawnDelay;
    [SerializeField] GameObject obstacle;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnObstacles();
        }
    }

    public void StopSpawning()
    {
        spawn = false;
    }

    void SpawnObstacles()
    {
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }
}
