using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeController : MonoBehaviour
{
    public float TposX;
    public float TposY;
    public int FSvar;
    public int SCNL;
    // Start is called before the first frame update
    void Start()
    {

        PlayerData.FieldStateArea = FSvar;


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (PlayerData.FieldStateArea == 0)
            {
                if (PlayerData.FieldState == 0)
                {
                    SCNL = 2;
                    TposX = -5;
                    TposY = 0;
                }
                else if (PlayerData.FieldState == 1)
                {

                }
                else if (PlayerData.FieldState == 2)
                {

                }
                else if (PlayerData.FieldState == 3)
                {

                }
                else
                {

                }
            }
            else if (PlayerData.FieldStateArea == 1)
            {
                if (PlayerData.FieldState == 0)
                {
                    SCNL = 1;
                    TposX = 4.3f;
                    TposY = 0;
                }
                else if (PlayerData.FieldState == 1)
                {
                    SCNL = 3;
                    TposX = -7;
                    TposY = -2;
                }
                else if (PlayerData.FieldState == 2)
                {

                }
                else if (PlayerData.FieldState == 3)
                {

                }
                else
                {

                }
            }
            else if (PlayerData.FieldStateArea == 2)
            {
                if (PlayerData.FieldState == 0)
                {
                    SCNL = 2;
                    TposX = 10;
                    TposY = 1;
                }
                else if (PlayerData.FieldState == 1)
                {
                    SCNL = 4;
                    TposX = -18;
                    TposY = -1.5f;
                }
                else if (PlayerData.FieldState == 2)
                {
                    SCNL = 10;
                    TposX = 0;
                    TposY = 0;
                }
                else if (PlayerData.FieldState == 3)
                {

                }
                else
                {

                }
            }
            else if (PlayerData.FieldStateArea == 3)
            {
                if (PlayerData.FieldState == 0)
                {
                    SCNL = 3;
                    TposX = -3;
                    TposY = 3;
                }
                else if (PlayerData.FieldState == 1)
                {

                }
                else if (PlayerData.FieldState == 2)
                {

                }
                else if (PlayerData.FieldState == 3)
                {

                }
                else
                {

                }

            }
            else if (PlayerData.FieldStateArea == 0)
            {
                if (PlayerData.FieldState == 0)
                {
                    SCNL = 3;
                }
                else if (PlayerData.FieldState == 1)
                {

                }
                else if (PlayerData.FieldState == 2)
                {

                }
                else if (PlayerData.FieldState == 3)
                {

                }
                else
                {

                }
            }
            PlayerData.playerPOSX = TposX;
            PlayerData.playerPOSY = TposY;
            SceneManager.LoadScene(SCNL);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
