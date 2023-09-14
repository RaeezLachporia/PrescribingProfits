using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PriceManager : MonoBehaviour
{
    public int insulPrice = 69;
    public int furoPrice = 32;
    public int sertraPrice = 55;
    [SerializeField] TextMeshProUGUI insulDisplay;
    [SerializeField] TextMeshProUGUI furoDisplay;
    [SerializeField] TextMeshProUGUI sertraDisplay;
    public PC pc;

    public bool doneWork;
    bool insulChanged = false;
    bool furoChanged = false;
    bool sertraChanged = false;

    void Start()
    {
        insulDisplay.text = "$ " + insulPrice.ToString();
        furoDisplay.text = "$ " + insulPrice.ToString();
        sertraDisplay.text = "$ " + insulPrice.ToString();
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
