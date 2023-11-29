using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPCDialogueBehaviour : MonoBehaviour
{
    public GameObject Interact;
    // Start is called before the first frame update
    void Start()
    {
        Interact.SetActive(false);
    }
    // Update is called once per frame
    public void  OnTriggerEnter2D(Collider2D other)
    {
        Interact.SetActive(true);
       
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        Interact.SetActive(false);
    }

}
