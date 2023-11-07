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
        Movement.x = PlayerData.playerPOSX;
        Movement.y = PlayerData.playerPOSY;
        rb.position = new Vector2 (Movement.x, Movement.y);
    }

    // Update is called once per frame
    void Update()
    {
        //input
        if(Input.GetKeyDown(KeyCode.W) | Input.GetKeyDown(KeyCode.S))
        {
            
            
        }
        else if  (Input.GetKeyDown(KeyCode.A) | Input.GetKeyDown(KeyCode.D))
        {
            
           
        }
        else
        {
            
        }
        Movement.y = Input.GetAxisRaw("Vertical");
        Movement.x = Input.GetAxisRaw("Horizontal");
        CBanimator.SetFloat("Horizontal", Movement.x);
        CBanimator.SetFloat("Vertical", Movement.y);
        CBanimator.SetFloat("Speed", Movement.sqrMagnitude);

    }
    private void FixedUpdate()
    {
         rb.MovePosition(rb.position + Movement * moveSpeed * Time.fixedDeltaTime);
        //movement
        
    }
    void LeftMove()
    {
        
    }
}
