using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float roateSpeed;
    public float jumpForce;
    
    public List<MeshRenderer> meshRenderer;
    public Color playerColor;

    private Rigidbody rb;
    private Vector3 dir;
    private bool canJump;
    private Color previousColor;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        dir = new Vector3();
        foreach (var renderer in meshRenderer)
        {
            renderer.material.color = playerColor;
        }

    }

    void Update()
    {
        dir.x = Input.GetAxisRaw("Vertical");
        dir.Normalize();

        transform.Translate(dir * speed * Time.deltaTime);
        transform.Rotate(0, Input.GetAxisRaw("Horizontal") * roateSpeed * Time.deltaTime, 0);

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(0, jumpForce, 0);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        var otherGameobjectsMaterial = collision.gameObject.GetComponent<MeshRenderer>().material;
        previousColor = otherGameobjectsMaterial.color;
        otherGameobjectsMaterial.color = Color.red;
        if (collision.transform.CompareTag("Ground"))
        {
            canJump = true;
        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        collision.gameObject.GetComponent<MeshRenderer>().material.color =  previousColor;
        if (collision.transform.tag == "Ground")
        {
            canJump = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger exited");
    }

}
