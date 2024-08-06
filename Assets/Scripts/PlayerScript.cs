using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody playerRigidbody;
    float MovementSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementDirection = Vector3.zero;

        if (Input.GetKey("a")) {
            movementDirection.x = -MovementSpeed;
        } else if (Input.GetKey("d")) {
            movementDirection.x = MovementSpeed;
        }

        if (Input.GetKey("w")) {
            movementDirection.z = MovementSpeed;
        } else if (Input.GetKey("s")) {
            movementDirection.z = -MovementSpeed;
        }

        playerRigidbody.AddForce(movementDirection * Time.deltaTime, ForceMode.VelocityChange);
    }

}

