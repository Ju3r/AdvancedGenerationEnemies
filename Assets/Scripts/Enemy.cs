using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Enemy : MonoBehaviour 
{
    private Mover _mover;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    private void Update()
    {
        _mover.Move();
    }

    public void Init(Target target)
    {
        SetTarget(target);
    }

    public void SetTarget(Target target)
    {
        _mover.SetTarget(target);
    }
}