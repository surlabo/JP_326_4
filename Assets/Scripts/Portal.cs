using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform spawnPoint;
    
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = spawnPoint.position;
    }
}
