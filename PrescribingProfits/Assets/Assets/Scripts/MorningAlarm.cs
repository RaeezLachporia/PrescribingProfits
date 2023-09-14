using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorningAlarm : MonoBehaviour
{
    public GameObject Alarm;
    public GameObject ScreenAlarm;
    public GameObject Screen;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Alarm.SetActive(false);
            ScreenAlarm.SetActive(false);
            Screen.SetActive(true);
        }
        
    }
}
