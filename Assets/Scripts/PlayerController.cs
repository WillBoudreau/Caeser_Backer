using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 1.0f;
    public Animator CBanimator;
    Vector2 Movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //input
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");
        CBanimator.SetFloat("Horizontal", Movement.x);
        CBanimator.SetFloat("Vertical", Movement.y);
        CBanimator.SetFloat("Speed", Movement.sqrMagnitude);

    }
    private void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position + Movement * moveSpeed * Time.fixedDeltaTime);
    }
}
