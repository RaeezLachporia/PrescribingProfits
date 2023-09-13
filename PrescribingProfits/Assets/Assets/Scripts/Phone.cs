using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    public GameObject phone;
    public bool phoneOut = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && phoneOut == false)
        {
            phone.SetActive(true);
            phoneOut = true;
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && phoneOut == true)
        {
            phone.SetActive(false);
            phoneOut = false;
        }
    }
}
