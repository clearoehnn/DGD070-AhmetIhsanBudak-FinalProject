using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public Transform cube;
    public float moveSpeed;

    private void Update()
    {
        Vector3 input = new Vector3(UnityEngine.Input.GetAxisRaw("Horizontal"), 0,
            UnityEngine.Input.GetAxisRaw("Vertical"));

        cube.position += input * (moveSpeed * Time.deltaTime);
    }
}
