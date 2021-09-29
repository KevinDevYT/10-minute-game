using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float jumpforce, rotatespeed;
    public Rigidbody2D rb;
    public bool isgrounded;
    public Quaternion rotate;
    bool rotatebool;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (isgrounded == true && Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpforce * Time.deltaTime * 100, ForceMode2D.Impulse);
            rotatebool = true;
        }
        if (rotatebool == true)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, rotate, rotatespeed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "ground")
        {
            isgrounded = true;
            transform.rotation = new Quaternion(0, 0, 0, 0);
            rotatebool = false;
        }
       
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isgrounded = false ;
    }
}
