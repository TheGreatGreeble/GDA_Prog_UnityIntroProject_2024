using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Rigidbody enemyRigidbody;
    float movementSpeed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector3 directionToPlayer = (player.transform.position - this.transform.position).normalized;
        enemyRigidbody.AddForce(directionToPlayer * movementSpeed * Time.deltaTime, ForceMode.VelocityChange);

    }
}
