using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tutorial : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        PlayerData.TalktoDave = false;
    }

    // Update is called once per frame
    void Update()
    {
       if(PlayerData.TalktoDave == true) 
        {
            Debug.Log("Hello World");
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag  == "Dave")
        {
            PlayerData.TalktoDave = true;
        }
    }
}
