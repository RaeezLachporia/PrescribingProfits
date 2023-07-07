using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whiteboard : MonoBehaviour, IInteractable
{
    public GameObject whiteBoard;

    public void Interact()
    {
        Debug.Log("whiteboard");
        whiteBoard.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            whiteBoard.SetActive(false);
        }
    }
}
