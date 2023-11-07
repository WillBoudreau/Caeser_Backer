using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quest1 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerData.TalktoDave = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Cult of the red feather raid the home
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Dave"))
        {
            PlayerData.TalktoDave = true;
        } 
        if (PlayerData.TalktoDave == true)
        {
            SceneManager.LoadScene(2);
        }
    }
}
