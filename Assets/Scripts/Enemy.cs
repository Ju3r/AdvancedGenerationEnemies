using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Enemy : MonoBehaviour 
{
    private Mover _mover;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    private void FixedUpdate()
    {
        _mover.Move();
    }

    public void Init(Vector3 target)
    {
        SetTarget(target);
    }

    public void SetTarget(Vector3 target)
    {
        _mover.SetTarget(target);
    }
}