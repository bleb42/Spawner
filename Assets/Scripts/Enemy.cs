using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _targetPosition;

    private void Update()
    {
        gameObject.transform.position = 
            Vector3.MoveTowards(gameObject.transform.position, _targetPosition, _speed * Time.deltaTime);

        if (gameObject.transform.position == _targetPosition)
        {
            Destroy(gameObject);
        }
    }

    public void SetTargetPosition(Vector3 targetPosition)
    {
        _targetPosition = targetPosition;
    }
}