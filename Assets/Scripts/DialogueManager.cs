using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public TextMeshProUGUI nametext;
    public TextMeshProUGUI dialoguetext;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        sentences = new Queue<string>();
    }
    public void StartDialogue (Dialogue dialogue)
    {
        panel.SetActive(true);
        nametext.text = dialogue.name;

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
            panel.SetActive(false);
            return;
        }
        string sentence = sentences.Dequeue();
        dialoguetext.text = sentence;
    }
    void EndDialogue()
    {
        Debug.Log("End of Conversation");
    }
}
