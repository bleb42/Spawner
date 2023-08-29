using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Enemy _enemyPrefab;

    public void SpawnEnemy()
    {
        Enemy enemy = Instantiate(_enemyPrefab, gameObject.transform.position, Quaternion.identity);

        enemy.SetATarget(_target);
    }
}
