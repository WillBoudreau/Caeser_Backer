using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    float textSpeed = 0.5f;

    public string name;

    [TextArea(3, 10)]
    public string[] sentences;
}
