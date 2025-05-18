using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(DestoryDelay());
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject, 3);
    }

    private IEnumerator DestoryDelay()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
