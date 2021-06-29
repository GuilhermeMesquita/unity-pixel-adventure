using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    private Rigidbody2D rb;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        initMove();
        initJump();
    }

    private void initMove()
    {
        float movement = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2((movement * speed), rb.velocity.y);

        if (movement < 0f)
        {
            anim.SetBool("Walk", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
        else if (movement > 0f)
        {
            anim.SetBool("Walk", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        else
        {
            anim.SetBool("Walk", false);
        }
    }

    private void initJump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}
