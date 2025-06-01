using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Klavye ok tuþlarý ya da WASD ile giriþleri al
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
       
            float move = Input.GetAxis("Horizontal") + Input.GetAxis("Vertical");

            if (move != 0)
            {
                animator.SetBool("isWalking", true);
                // hareket kodu burada olacak
            }
            else
            {
                animator.SetBool("isWalking", false);
            }

    }


    void FixedUpdate()
    {
        // Rigidbody ile hareketi uygula
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public Animator animator; // Player'ýn Animator componentini baðla
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Biri trigger'a çarptý: " + other.name);
    }


}

