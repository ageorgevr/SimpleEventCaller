using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    Coroutine spawnroutine;

    private void Start()
    {
        GameManager.instance.gameStarted += StartSpawning;
        GameManager.instance.gameLost += StopSpawning;
    }

    private void StartSpawning()
    {
        spawnroutine = StartCoroutine(SpawnEnemies());
    }

    private void StopSpawning()
    {
        if (spawnroutine != null)
        {
            StopCoroutine(spawnroutine);
        }
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            Vector3 SpawnPosition = new Vector3(Random.Range(-6.5f, 6.5f), 7f, -2.35f);
            var enemy = Instantiate(enemyPrefab, SpawnPosition, Random.rotation);

            yield return new WaitForSeconds(2f);
        }

    }
}
