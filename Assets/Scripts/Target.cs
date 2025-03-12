using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Target : MonoBehaviour 
{
    private const int StartIndex = 0;

    [SerializeField] private List<WayPoint> _wayPoints = new List<WayPoint>();

    private Mover _mover;
    private int _currentWayPointIndex = StartIndex;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    private void Update()
    {
        _mover.Move(_wayPoints[_currentWayPointIndex].transform.position);
    }

    public void SetNextWayPoint()
    {
        if ((_currentWayPointIndex + 1) < _wayPoints.Count)
            _currentWayPointIndex++;
        else
            _currentWayPointIndex = StartIndex;
    }

    public bool IsWayPointOnList(WayPoint wayPoint)
    {
        return _wayPoints.Contains(wayPoint);
    }
}