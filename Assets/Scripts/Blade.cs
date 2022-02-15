using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    public float minimumVelocity = 0.1f;

    private Rigidbody2D rigidBody;
    private Vector3 lastBladePosition;
    private Collider2D coll;

    public void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
    }

    public void FixedUpdate()
    {
        coll.enabled = CheckIfBladeIsMoving();
        FixBladeToMousePosition();
    }

    private void FixBladeToMousePosition()
    {

        var mousePosition = Input.mousePosition;
        mousePosition.z = 10;

        rigidBody.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }

    private bool CheckIfBladeIsMoving()
    {
        Vector3 currentBladePosition = transform.position;
        float travelled = (lastBladePosition - currentBladePosition).magnitude;
        lastBladePosition = currentBladePosition;

        if (travelled > minimumVelocity)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
