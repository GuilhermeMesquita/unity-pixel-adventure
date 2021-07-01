using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineBehaviour : MonoBehaviour
{
    public float jumpForce;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetTrigger("Jump");
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

        }
    }
}
