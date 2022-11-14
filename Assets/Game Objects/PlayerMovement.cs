using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float horizontal;
    [SerializeField] private float vertical;
    [SerializeField] private Rigidbody2D rb;
/*    [SerializeField] private Animator animator;*/

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
/*        animator = GetComponent<Animator>();*/
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        FixedUpdate();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, vertical * speed);
/*        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);
        animator.SetFloat("Speed", rb.velocity.magnitude);*/
    }

    
}
