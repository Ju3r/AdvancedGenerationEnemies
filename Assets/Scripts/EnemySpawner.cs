using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints = new List<SpawnPoint>();

    private float _delay = 2f;
    private bool _isSpawning = true;

    private void Start()
    {
        StartCoroutine(ContinuousSpawn());
    }

    private void Spawn()
    {
        foreach (var spawnPoint in _spawnPoints)
        {
            Enemy enemy = Instantiate(spawnPoint.Enemy, spawnPoint.transform.position, Quaternion.identity);
            enemy.Init(spawnPoint.Target);
        }
    }

    private IEnumerator ContinuousSpawn()
    {
        WaitForSeconds wait = new WaitForSeconds(_delay);

        while (_isSpawning)
        {
            Spawn();

            yield return wait;
        }
    }
}