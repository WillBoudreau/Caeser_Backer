using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using System.IO;

public class DialogueManager2 : MonoBehaviour
{
    private Queue<string> sentences;
    public TextMeshProUGUI nametext;
    public TextMeshProUGUI dialoguetext;
    public GameObject panel;
    public Dialogue dialogue;
    public bool startend;
    //public string path = @"GrandPappiDialogue.txt";
    //public string[] Dialogues;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        sentences = new Queue<string>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) == true)
        {
            if (panel.activeSelf == true)
            {
                DisplayNextSentence();
            }
            else
            {
               panel.SetActive(true);
               StartDialogue(dialogue);
            }
        }
        
    }
    public void AltTrigger()
    {
        StartDialogue(dialogue);
    }
    public void StartDialogue(Dialogue dialogue)
    {
        //sentences.Clear();
        startend = false;
        nametext.text = dialogue.name;
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        string sentence = sentences.Dequeue();
        dialoguetext.text = sentence;
        if (sentences.Count == 0)
        {
            EndDialogue();
            //panel.SetActive(false);
            //startend = true;
            return;
        } 
    }
    void EndDialogue()
    {
        Time.timeScale = 1.0f;
        panel.SetActive(false);    

    }
}

        //string test;
        //Time.timeScale = 0.0f;
        // test = File.ReadAllText(path);
        //Dialogues = test.Split('\n');
        //for (int i = 0; i < Dialogues.Length; i++)
        //{
        //    dialoguetext.text = Dialogues[i];
        //}