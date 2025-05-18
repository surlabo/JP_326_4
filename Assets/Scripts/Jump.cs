using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce;
    public float detectionDistance;

    private Rigidbody rb;
    private bool canJump;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        DetectGround();
        AddForceToPlayer();
        DrawRay();
    }

    private void DetectGround() 
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        canJump = Physics.Raycast(ray, detectionDistance, 1 << 7);
    }

    private void AddForceToPlayer()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(0, jumpForce, 0);
        }
    }
    
    private void DrawRay()
    {
        Debug.DrawRay(transform.position, Vector3.down * detectionDistance, Color.white);
    }
}
