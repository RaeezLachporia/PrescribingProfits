using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour, IInteractable
{
   
    public GameObject screen;
    public static bool canLeave = false;
    public bool pcOpen = false;

    public void Interact()
    {
        Debug.Log("PC");
        screen.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        pcOpen = true;
        canLeave = true;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            screen.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            pcOpen = false;
        }        
    }
    
}
