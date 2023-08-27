using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform _targetPosition;
    [SerializeField] private Enemy _enemy;

    public void SpawnEnemy()
    {
        Enemy enemy = Instantiate(_enemy, gameObject.transform.position, Quaternion.identity);

        enemy.SetTargetPosition(_targetPosition.transform.position);
    }
}
