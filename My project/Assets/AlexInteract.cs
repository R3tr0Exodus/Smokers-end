using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class AlexInteract : MonoBehaviour, IInteractable
{   
    dialogue dialogueOnInteraction;

    void Start()
    {
        dialogueOnInteraction = GetComponent<dialogue>();
    }

    public void Interact()
    {
        //Code to be run on interact goes here!!!
        dialogueOnInteraction.StartDialogue();
    }
}