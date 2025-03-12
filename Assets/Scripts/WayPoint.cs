using UnityEngine;

[RequireComponent(typeof(Collider))]
public class WayPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Target target))
        {
            if (target.IsWayPointOnList(this))
                target.SetNextWayPoint();
        }
    }
}