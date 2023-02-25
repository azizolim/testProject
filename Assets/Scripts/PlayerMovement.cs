using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed = 5.0f;  
    [SerializeField] private float minX;
    [SerializeField] private float maxX;


    void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");


        Vector3 newPosition = transform.position + new Vector3(moveHorizontal * speed * Time.deltaTime, 0, 0);


        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);

        transform.position = newPosition;
    }

    
}
