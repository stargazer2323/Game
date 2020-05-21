using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.Instance.Die();
    }


}
