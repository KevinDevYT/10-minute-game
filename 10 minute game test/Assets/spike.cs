using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike : MonoBehaviour
{
    public Vector2 tar;
    public float movespeed;
    Vector2 current;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        current = transform.position;
        transform.position = Vector2.MoveTowards(current, tar, movespeed * Time.deltaTime);
    }
}
