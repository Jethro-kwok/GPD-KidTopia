using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlingBaby : MonoBehaviour
{
   /* private Vector3 directionVector;
    private Transform myTransform;
    public float speed;
    private Rigidbody2D rb;
    private Animator anim;
    public Collider2D area;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        ChangeDir();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 temp = myTransform.position + directionVector * speed * Time.deltaTime;
        if (!area.Area.Contains(temp))
        {
            rb.MovePosition(temp);
        }
        else
        {
            ChangeDir();
        }
       
    }

    void ChangeDir()
    {
        int direction = Random.Range(0, 4);

        switch (direction)
        {
            case 0:
                directionVector = Vector3.right;
                break;
            case 1:
                directionVector = Vector3.up;
                break;
            case 2:
                directionVector = Vector3.left;
                break;
            case 3:
                directionVector = Vector3.down;
                break;
            default:
                break;
        }

        UpdateAnimation();
    }

    void UpdateAnimation()
    {
        anim.SetFloat("MoveX", directionVector.x);
        anim.SetFloat("MoveY", directionVector.y);
        anim.SetFloat("Move-X", -directionVector.x);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Vector3 temp = directionVector;
        ChangeDir();

        int loops = 0;
        while(temp == directionVector && loops < 0)
        {
            loops++;
            ChangeDir();
        }
    }*/
}
