using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;

public class DialogueManager2 : MonoBehaviour
{
    private Queue<string> sentences;
    public TextMeshProUGUI nametext;
    public TextMeshProUGUI dialoguetext;
    public GameObject panel;
    public Dialogue dialogue;
    public GameObject Interact;
    // Start is called before the first frame update
    void Start()
    {
        Interact.SetActive(false);
        panel.SetActive(false);
        sentences = new Queue<string>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Interact.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Interact.SetActive(false);
    }
    void Update()
    {
        if(Interact.activeSelf == true)
        {
          if (Input.GetKeyDown(KeyCode.E) == true)
          {
                TriggerDialogue();
          }
        }  
    }
    public void TriggerDialogue()
    {
        {
            StartDialogue(dialogue);
        }
    }
    public void StartDialogue(Dialogue dialogue)
    {
        Time.timeScale = 0.0f;
        panel.SetActive(true);
        nametext.text = dialogue.name;  
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
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
        Time.timeScale= 1.0f;
    }
}