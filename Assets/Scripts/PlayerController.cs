using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 0.25f;
    public Animator CBanimator;
    Vector2 Movement;
    int KeyDireh;
    int KeyDirev;
    // Start is called before the first frame update
    void Start()
    {
        PlayerData.playerScene = SceneManager.GetActiveScene().buildIndex;
        Time.timeScale = 1.0f;
        Movement.x = PlayerData.playerPOSX;
        Movement.y = PlayerData.playerPOSY;
        rb.position = new Vector2(Movement.x, Movement.y);
    }

    // Update is called once per frame
    void Update()
    {
        
        //input
        //if (Input.GetKey(KeyCode.W))
        //{
        //    KeyDirev = 1;

        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    KeyDirev = 0;

        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    KeyDireh = 1;

        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    KeyDireh = 0;

        //}
        //else
        //{
        //    KeyDireh = 0;
        //    KeyDirev = 0;

        //}
        Movement.y = Input.GetAxisRaw("Vertical");
        Movement.x = Input.GetAxisRaw("Horizontal");

    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Movement * moveSpeed * Time.fixedDeltaTime);
        PlayerData.playerPOSX = Movement.x;
        PlayerData.playerPOSY = Movement.y;
        CBanimator.SetFloat("Horizontal", Movement.x);
        CBanimator.SetFloat("Vertical", Movement.y);
        CBanimator.SetFloat("Speed", Movement.sqrMagnitude);
        //movement

    }
    void SetStats()
    {

    }
}