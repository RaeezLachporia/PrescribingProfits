using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public GameObject backToWork;
    public void Interact()
    {
        Debug.Log("PC");
        backToWork.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            backToWork.SetActive(false);
        }
    }
}
