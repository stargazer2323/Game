using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Cube>() != null)
        {
            GameController.Instance.Score();
        }
        
    }
}
