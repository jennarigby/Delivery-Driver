using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.1f;

    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
       float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
       transform.Rotate(0, 0, -steerAmount);
       float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
       transform.Translate(0, moveAmount, 0);     
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Boost"){
            moveSpeed = boostSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
    }
}

    