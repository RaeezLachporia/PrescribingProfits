using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour, IInteractable
{
    public GameObject backToWork;
    public GameObject congradulation;

    public void Interact()
    {
        if (PC.canLeave == true)
        {
            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                congradulation.SetActive(true);
            }
            else
            {
                SceneManager.LoadScene("HomeDayOne");
            }
        }
        else
        {
            Debug.Log("PC");
            backToWork.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            backToWork.SetActive(false);
        }
    }
}
