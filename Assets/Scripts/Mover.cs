using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _speed = 5f;

    private Vector3 _target = new Vector3();
    
    public void Move()
    {
        if (_target == Vector3.zero)
            return;

        SetRotationToTarget();

        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.fixedDeltaTime);
    }

    public void SetTarget(Vector3 target)
    {
        _target = target;
    }

    private void SetRotationToTarget()
    {
        transform.rotation = Quaternion.Euler(_target);
    }
}
