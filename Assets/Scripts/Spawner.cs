using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private GameObject _targetPosition;
    [SerializeField] private float _spawnInterval = 2f;
    [SerializeField] private int _enemiesCount;
    
    private Transform[] _spawnPoints;

    private void Awake()
    {
        _spawnPoints = GetComponentsInChildren<Transform>();
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
            Transform randomSpawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
            Transform newEnemy = Instantiate(_enemyPrefab.transform, randomSpawnPoint.position, Quaternion.identity);

            Vector3 movementDirection = _targetPosition.transform.position;
            Enemy enemyMovement = newEnemy.GetComponent<Enemy>();
           
            if (enemyMovement != null)
            {
                enemyMovement.SetTargetPosition(movementDirection);
            }

            yield return spawnInterval;
        }
    }
}