using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReapitingWalls : MonoBehaviour
{
    private BoxCollider2D wallsCollider;
    public float wallsLenght;
    

    void Start()
    {
        wallsCollider = GetComponent<BoxCollider2D>();
        wallsLenght = wallsCollider.size.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<-wallsLenght)
        {
            RepositionWalls();

        }
    }

    private void RepositionWalls()
    {
        Vector2 wallsOffset = new Vector2(0, wallsLenght * 2);
        transform.position = (Vector2)transform.position + wallsOffset;
       
    }
}
