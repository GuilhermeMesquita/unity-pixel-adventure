using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public float floatingTime;
    private TargetJoint2D targetJoint2D;
    private BoxCollider2D boxCollider2D;

    // Start is called before the first frame update
    void Start()
    {
        targetJoint2D = GetComponent<TargetJoint2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Invoke("Falling", floatingTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 6)
        {
            Destroy(gameObject);
        }
    }

    private void Falling()
    {
        targetJoint2D.enabled = false;
        boxCollider2D.isTrigger = true;
    }
}
