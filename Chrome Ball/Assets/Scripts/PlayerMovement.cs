using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float speed = 3f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed *= 10;
    }
    
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalMovement, 0.0f, verticalMovement);

        rb.AddForce(movement * speed * Time.deltaTime);
    }
}
