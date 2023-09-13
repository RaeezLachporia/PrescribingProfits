using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bed : MonoBehaviour, IInteractable
{
    public GameObject goodnight;
    bool canSleep = false;

    public void Interact()
    {
        goodnight.SetActive(true);
        canSleep = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canSleep == true)
        {
            SceneManager.LoadScene("HomeDayTwo_Morning");
        }
    }
}
