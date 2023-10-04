using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeController : MonoBehaviour
{
    public int SCNL;
    // Start is called before the first frame update
    void Start()
    {

        

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            SceneManager.LoadScene(SCNL);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
