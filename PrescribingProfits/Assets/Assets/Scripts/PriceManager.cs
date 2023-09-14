using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PriceManager : MonoBehaviour
{
    int insulPrice = 69;
    int furoPrice = 32;
    int sertraPrice = 55;
    GameObject isulField;
    public PC pc;

    public bool doneWork;
    bool insulChanged = false;
    bool furoChanged = false;
    bool sertraChanged = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "OfficeBlockDayOne" && insulChanged == true)
        {
            doneWork = true;
        }
        else if (SceneManager.GetActiveScene().name == "OfficeBlockDayTwo" && insulChanged == true && furoChanged == true)
        {
            doneWork = true;
        }
        else if (SceneManager.GetActiveScene().name == "OfficeBlockDayThree" && insulChanged == true && furoChanged == true && sertraChanged == true)
        {
            doneWork = true;
        }

    }

    public void GetInsulin(string i)
    {
        insulPrice = int.Parse(i);
        Debug.Log(insulPrice);

        insulChanged = true;
    }

    public void GetFurosemide(string f)
    {
        furoPrice = int.Parse(f);
        Debug.Log(furoPrice);

        furoChanged = true;
    }

    public void GetSertraline(string s)
    {
        sertraPrice = int.Parse(s);
        Debug.Log(sertraPrice);

        sertraChanged = true;
    }

}
