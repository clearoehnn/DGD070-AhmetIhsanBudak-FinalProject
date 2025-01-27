using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool canMove = true;
    public float speed;
    float xPos;
    float zPos;

    public GameController gameController;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        xPos += horizontalInput * Time.deltaTime * speed;
        zPos += verticalInput * Time.deltaTime * speed;

        xPos = Mathf.Clamp(xPos, -40, 40);
        zPos = Mathf.Clamp(zPos, -22, 22);

        if (canMove)
        {
            transform.position = new Vector3(xPos, 0, zPos);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            gameController.Collected(other.gameObject);
        }
    }
}
