using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getFruit : MonoBehaviour
{
    public GameObject collected;
    public int score;
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
            score++;
            GameController.instance.totalScore += score;
            GameController.instance.updateScoreText();
            Destroy(gameObject, 0.24f);
        }
    }
}
