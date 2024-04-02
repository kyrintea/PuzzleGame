using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour
{
    //for mouse position
    private Vector3 mousePosition;
    public float moveSpeed = 1f;

    public Transform target;
    public float speed = 3f;
    //private RigidBody2D rb;

 

    private void Start()
    {
        //rb = GetComponent<RigidBody2D>();
    }

    private void Update()
    {
        MousePosition();
        //get target
        //rotate toward target
    }

    private void FixedUpdate()

    {
        //move
    }

    private void MousePosition()
    {
        /*//this is from other game where flashlightGO follows mouse position
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);*/
    }

//toggle back and forth code
    /* //light toggles on and off with right click
        if (Input.GetMouseButtonDown(1) && batteryPercentage > 1)
        {
            if (lightGO.activeSelf)
            {
                lightGO.SetActive(false);
                flashlightON = false;
                //print(flashlightON);
            }

            else
{
    lightGO.SetActive(true);
    flashlightON = true;
    //print(flashlightON);
}*/

    //this line makes a sphere GO (specified in a serializefield) move towards the position of a cube GO (also in serializefield) at a set speed (int or f initialized at top)
    //Sphere.transform.position = Vector3.MoveTowards(Sphere.transform.position, Cube.transform.position, speed);

}
