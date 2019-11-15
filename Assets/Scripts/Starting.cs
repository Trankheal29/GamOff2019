using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starting : MonoBehaviour
{

    public Dialogue dialogues;
    Dialogue.Info[] dialogue;
    // Start is called before the first frame update
    void Start()
    {
        dialogue = dialogues.dialogueInfo;
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    
}
