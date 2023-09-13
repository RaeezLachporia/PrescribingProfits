using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class OfficePhone : MonoBehaviour, IInteractable
{

    public bool bossCalled = false;
    public GameObject Dialog;
    [SerializeField] TextMeshProUGUI bossDialog;
    int dialogPage = 0;
    public SFX sfx;

    public void Interact()
    {
        Debug.Log("Phone");

        if(bossCalled == false)
        {
            Dialog.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && SceneManager.GetActiveScene().name == "OfficeBlockDayOne")
        {
            dialogPage++;

            switch (dialogPage)
            {
                case 1:
                    bossDialog.text = "This is your Boss Speaking";
                    sfx.PlaySound("VoiceOne");
                    break;

                case 2:
                    bossDialog.text = "It has come to my attention that our competetors prices have been rising";
                    sfx.PlaySound("VoiceTwo");
                    break;

                case 3:
                    bossDialog.text = "This is because they have realised they can sell life savong medicine for a large profit";
                    sfx.PlaySound("VoiceThree");
                    break;

                case 4:
                    bossDialog.text = "I have also noticed that we are not doing this";
                    sfx.PlaySound("VoiceFour");
                    break;

                case 5:
                    bossDialog.text = "Fix this";
                    sfx.PlaySound("VoiceFive");
                    break;

                case 6:
                    bossDialog.text = "Start with insulin";
                    sfx.PlaySound("VoiceFive");
                    break;

                case 7:
                    Dialog.SetActive(false);
                    break;
            }
        }
    }
}