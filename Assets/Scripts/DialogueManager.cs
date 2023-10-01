using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {

        //nameText.text = dialogue.name;

        sentences = new Queue<string>();
    }
    public void StartDialogue (Dialogue dialogue)
    {
        sentences.Clear();

        foreach(string sentence in dialogue.sentences )
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
       // dialogueText.text = sentence;
    }
    void EndDialogue()
    {
        Debug.Log("End of Conversation");
    }
}
