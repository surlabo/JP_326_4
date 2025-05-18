using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnPoint;
    public float shootForce;

    private Rigidbody rb;



    public void  ShootBullet()
    {
        if (GameManager.Instance.isGamePoused) return;
        var bulletClone = Instantiate(bulletPrefab, 
            spawnPoint.position, Quaternion.identity);
        var bulletRgidbody = bulletClone.GetComponent<Rigidbody>();
        bulletRgidbody.AddForce(transform.forward * shootForce);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ShootBullet();
        }

    }
}
