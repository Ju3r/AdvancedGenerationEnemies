using UnityEngine;

public class Enemy : MonoBehaviour 
{
    [SerializeField] private float _speed = 1f;

    private Target _target;

    private void FixedUpdate()
    {
        Move();
    }

    public void Init(Target target)
    {
        _target = target;
    }

    private void Move()
    {
        if (_target == null)
            return;

        transform.rotation = Quaternion.Euler(_target.transform.position);
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.fixedDeltaTime);
    }
}