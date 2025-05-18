using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private float deathPoint;


    void Update()
    {
        if (transform.position.y < deathPoint)
        {
            GameManager.Instance.RespawnPlayer();
        }
    }
}
