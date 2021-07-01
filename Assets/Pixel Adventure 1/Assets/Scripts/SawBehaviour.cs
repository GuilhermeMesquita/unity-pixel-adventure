using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawBehaviour : MonoBehaviour
{
    public float speed;
    public float moveTime;
    private bool rightDirection;
    private float timer;
    // Update is called once per frame
    void Update()
    {
        if (rightDirection)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        timer += Time.deltaTime;
        if (timer >= moveTime)
        {
            rightDirection = !rightDirection;
            timer = 0f;
        }
    }



}
