using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour 
{
    [SerializeField] private List<WayPoint> _wayPoints = new List<WayPoint>();
    [SerializeField] private float _speed = 1f;

    private const int StartIndex = 0;
    private int _currentWayPointIndex = StartIndex;

    private void FixedUpdate()
    {
        Move(_wayPoints[_currentWayPointIndex].transform.position);
    }

    public void SetNextWayPoint()
    {
        _currentWayPointIndex = (++_currentWayPointIndex) % _wayPoints.Count;

    }

    public bool IsWayPointOnList(WayPoint wayPoint)
    {
        return wayPoint.transform == _wayPoints[_currentWayPointIndex].transform;
    }

    private void Move(Vector3 position)
    {
        transform.position = Vector3.MoveTowards(transform.position, position, _speed * Time.fixedDeltaTime);
    }
}