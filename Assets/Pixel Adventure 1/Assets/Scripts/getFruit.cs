using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getFruit : MonoBehaviour
{
    public GameObject collected;

    private SpriteRenderer spriteRenderer;
    private CircleCollider2D boxCollider2D;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<CircleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spriteRenderer.enabled = false;
            boxCollider2D.enabled = false;
            collected.SetActive(true);

            Destroy(gameObject, 0.24f);
        }
    }
}
