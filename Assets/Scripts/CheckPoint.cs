using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] private int index;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.ChangeSpawnPoint(index);
        }
    }
}
