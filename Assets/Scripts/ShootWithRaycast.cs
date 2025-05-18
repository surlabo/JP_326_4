using System.Collections;
using UnityEngine;

public class ShootWithRaycast : MonoBehaviour
{
    public float bulletSpeed = 100;
    public Color myColor;
    public Color raycastColor;
    public LayerMask hitMask;
    public string enemyTag = "Enemy";
    public string targetTag = "Target";
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        // if (Physics.Raycast(ray, out RaycastHit hitt, 3, 1 << 3 | 1 << 6)) ;
        if (Physics.Raycast(ray, out RaycastHit hit, 3, hitMask))
        {
            hit.transform.GetComponent<MeshRenderer>().material.color =
                new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            Debug.Log(hit.transform.name);
            #region shoot functionality
            //var distance = Vector3.Distance(Vector3.zero, Vector3.one);
            //var timeToHit = distance / bulletSpeed;

            //StartCoroutine(ShootBulletCoroutine(timeToHit, hit.point)
            #endregion
        }

        Debug.DrawRay(transform.position, transform.forward * 3, raycastColor);
           
    }

    #region shoot coroutine
    //IEnumerator ShootBulletCoroutine(float time, Vector3 hitPosition)
    //{
    //    Instantiate(gameObject);
    //    yield return new WaitForSeconds(time);
    //    Instantiate(gameObject, hitPosition, Quaternion.identity);

    //}
    #endregion
}


