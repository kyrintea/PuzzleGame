using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour
{
    public Transform target;
    public float speed = 3f;
    public float rotateSpeed = 0.25f;
    private Rigidbody2D rb;
    public bool isActive = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (!target)
        {
            GetTarget();
        }

        if (target)
        {
            RotateTowardsTarget();
        }

        if (Input.GetMouseButtonDown(1))
        {
            isActive = !isActive;
            //print(isActive);
        }
    }

    private void FixedUpdate()
    {
        ActiveFollow();
    }

    private void GetTarget()
    {
        target = GameObject.FindGameObjectWithTag("Cursor").transform;
    }
    private void RotateTowardsTarget()
    {
        Vector2 targetDirection = target.position - transform.position;
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.Euler(new Vector3(0, 0, angle));
        transform.localRotation = Quaternion.Lerp(transform.localRotation, q, rotateSpeed);
    }

    private void ActiveFollow()
    {
        if (isActive)
        {
            rb.velocity = transform.right * speed;
        }

        else
        {
            rb.velocity = Vector2.zero;
        }
    }
    //this line makes a sphere GO (specified in a serializefield) move towards the position of a cube GO (also in serializefield) at a set speed (int or f initialized at top)
    //Sphere.transform.position = Vector3.MoveTowards(Sphere.transform.position, Cube.transform.position, speed);

}
