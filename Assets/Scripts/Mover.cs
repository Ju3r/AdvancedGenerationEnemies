using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _speed = 1f;

    public Target Target { get; private set; }
    
    public void Move()
    {
        if (Target == null)
            return;

        SetRotationToTarget();

        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, _speed * Time.fixedDeltaTime);
    }

    public void Move(Vector3 position)
    {
        transform.position = Vector3.MoveTowards(transform.position, position, _speed * Time.fixedDeltaTime);
    }

    public void SetTarget(Target target)
    {
        Target = target;
    }

    private void SetRotationToTarget()
    {
        transform.rotation = Quaternion.Euler(Target.transform.position);
    }
}