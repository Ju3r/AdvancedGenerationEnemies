using UnityEngine;

public class SpawnPoint : MonoBehaviour 
{
    [field: SerializeField]
    public Enemy Enemy { get; private set; }

    [field: SerializeField]
    public Transform Target { get; private set; }
}