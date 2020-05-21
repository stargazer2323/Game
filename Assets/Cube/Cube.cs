using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class Cube : MonoBehaviour
{
    public Rigidbody2D rb;
    
    public float speed = 15f;
    public float mapWidth = 7.8f;
    public float upForce = 100f;
    

    void Start()
     {
        rb = GetComponent<Rigidbody2D>();
        
     }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        Vector2 newPosition = rb.position + Vector2.right * x;
        
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

        
        rb.MovePosition(newPosition);
       // Jump();

        
    }
    /*void Jump()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float jumpV = 10f;
            rb.AddForce(transform.up*500);

            Debug.Log("hi");
        }
    }*/
   


}
