using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour, IInteractable
{
    public GameObject backToWork;
    private PriceManager pm;

    public void Interact()
    {

        if (SceneManager.GetActiveScene().name == "OfficeDayOne")
        {
            if (pm.doneWork == true)
            {
                SceneManager.LoadScene("HomeDayOne");
            }
            else
            {
                backToWork.SetActive(true);
            }
        }
        else if (SceneManager.GetActiveScene().name == "HomeDayOne")
        {
                backToWork.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "HomeDayTwoMoring")
        {
            SceneManager.LoadScene("OfficeBlockDayTwo");
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
