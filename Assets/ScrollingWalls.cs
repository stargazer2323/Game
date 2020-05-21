using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingWalls : MonoBehaviour
{
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(0, -GameController.Instance.speed*4);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.Instance.isGameOver)
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}
