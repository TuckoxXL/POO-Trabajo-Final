using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class platformMovement : MonoBehaviour
{
    [SerializeField] private float velocity;

    [SerializeField] private Transform floorController;

    [SerializeField] private float distance;

    [SerializeField] private bool moveRight;

    private Rigidbody2D rb;

    public float vision_range;

    public GameObject range;

    public GameObject target;

    public void Comportamiento()
    {
        if (transform.position.x < target.transform.position.x)
        {
            transform.Translate(Vector3.right * velocity * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.Translate(Vector3.right * velocity * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        RaycastHit2D floorInformation = Physics2D.Raycast(floorController.position, Vector2.down, distance);

        rb.velocity = new Vector2(velocity, rb.velocity.y);

        if (floorInformation == false)
        {
            //Spin
            Spin();
        }
    }

    private void Spin()
    {
        moveRight = !moveRight;
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
        velocity *= -1;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(floorController.transform.position, floorController.transform.position + Vector3.down * distance); 
    }
}
