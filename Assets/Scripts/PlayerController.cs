using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform movePoint;
    public Transform moveTarget;

    public float moveSpeed;
    public Animator CBanimator;

    // Start is called before the first frame update
    void Start()
    {
        moveTarget.position = new Vector3(PlayerData.playerPOSX, PlayerData.playerPOSY, 0.0f);
        moveSpeed = 0.01f;
        movePoint.parent = null;



        // Update is called once per frame
    }
    void Update()
    {
        moveTarget.position = Vector3.MoveTowards(moveTarget.position, movePoint.position, moveSpeed);
        if (Vector3.Distance(moveTarget.position, movePoint.position) <= 0.01f)
        {
                
            CBanimator.SetFloat("Horizontal", 0);

            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1)
            {
                //if (Input.GetButtonDown("Left"))
                //{

                //}
                //else if (Input.GetButtonDown("Right"))
                //{

                //}
                //else
                //{
                movePoint.position += new Vector3((Input.GetAxisRaw("Horizontal") / 2), 0.0f, 0.0f);
                CBanimator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));

                //}

            }
            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1)
            {
                //if (Input.GetButtonDown("Up"))
                //{

                //}
                //else if (Input.GetButtonDown("Down"))
                //{

                //}
                //else
                //{
                movePoint.position += new Vector3(0.0f, (Input.GetAxisRaw("Vertical") / 2), 0.0f);
                CBanimator.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));
                //}

            }

        }
        CBanimator.SetFloat("Horizontal", 0);
        CBanimator.SetFloat("Vertical", 0);

    }
    private void FixedUpdate()
    {


            //movement


    }
        
    }

