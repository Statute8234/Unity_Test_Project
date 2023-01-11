using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipAndMove : MonoBehaviour
{
    private Rigidbody2D rb;
    // move or not move
    private bool isfollowing = true;
    public AIPath aIPath;
    // flip image
    private Vector2 Position;
    private Vector3 size;
    private Vector2 flip;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Position = rb.transform.position;
        size = rb.transform.localScale;
        flip = new Vector2(-size.x, size.x);
    }

    // Update is called once per frame
    void Update()
    {
        // flip image
        if (Position.x < rb.transform.position.x)
        {
            rb.transform.localScale = new Vector3(flip.y, size.y,size.z);
            Position = rb.transform.position;
        }
        else if (Position.x > rb.transform.position.x)
        { 
            rb.transform.localScale = new Vector3(flip.x, size.y, size.z);
            Position = rb.transform.position;
        }
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    void OnMouseDown() {
        if (Input.GetMouseButtonDown(0))
        {
            if (isfollowing)
            {
                aIPath.maxSpeed = 2;
                isfollowing = false;
            } else
            {
                aIPath.maxSpeed = 0;
                isfollowing = true;
            }
        }
    }
}
