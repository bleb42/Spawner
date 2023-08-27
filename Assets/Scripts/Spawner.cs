using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _spawnInterval = 2f;
    [SerializeField] private int _enemiesCount;
    
    private SpawnPoint[] _spawnPoints;

    private void Awake()
    {
        _spawnPoints = GetComponentsInChildren<SpawnPoint>();
    }

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        var spawnInterval = new WaitForSeconds(_spawnInterval);

        for (int i = 0; i < _enemiesCount; i++)
        {
            SpawnPoint randomSpawnpPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
            SpawnPoint spawnPoint = randomSpawnpPoint.GetComponent<SpawnPoint>();

            if (spawnPoint != null)
            {
                spawnPoint.SpawnEnemy();
            }

            yield return spawnInterval;
        }
    }
}