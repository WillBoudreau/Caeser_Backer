using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float HorizontaInput;
    float VerticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontaInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

    }
}
