using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerSoul : MonoBehaviour
{
    public Dialogue dialogues;
    Dialogue.Info[] dialogue;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Soul"))
        {
            dialogue = dialogues.dialogueInfo;
            TriggerDialogue();
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
