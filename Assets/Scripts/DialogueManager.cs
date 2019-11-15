using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    

    public TextMeshProUGUI textDisplay;
    GameObject portrait;

    public Animator animator;
    
    public float typingSpeed;

    Queue<Dialogue.Info> dialogueInfo;
    //Queue<string> sentences;
    private void Awake()
    {

        dialogueInfo = new Queue<Dialogue.Info>();
        //sentences = new Queue<string>();
        
    }

   IEnumerator TypeSentence(string sentence)
   {
        textDisplay.text = "";

       foreach (char letter in sentence.ToCharArray())
       {
            textDisplay.text += letter;
            yield return null;
       }
   }

    public void StartDialogue(Dialogue.Info[] dialogue)
    {
        animator.SetBool("IsOpen", true);
        
      
        dialogueInfo.Clear();
        //sentences.Clear();

        foreach(Dialogue.Info info in dialogue)
        {
            dialogueInfo.Enqueue(info);
            //sentences.Enqueue(sentence);
        }
       
            DisplayNextSentence();
        
      
    }

    public void DisplayNextSentence()
    {
        

        if (portrait != null)
        {
            portrait.SetActive(false);
        }
        
        if (dialogueInfo.Count == 0)
        {
            EndDialogue();
            return;
        }
        Dialogue.Info info = dialogueInfo.Dequeue();

        portrait = info.portrait;
        string sentence = info.sentences; //sentences.Dequeue();

        portrait.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        Time.timeScale = 0f;

    }

    public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        portrait.SetActive(false);
        Time.timeScale = 1f;
    }
}
