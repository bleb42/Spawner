using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _targetPosition;

    private void Update()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, _targetPosition, _speed * Time.deltaTime);
    }

    public void SetMovementDirection(Vector3  targetPosition)
    {
        _targetPosition = targetPosition;
    }
}