using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectButton : MonoBehaviour
{
    public GameObject ContinueButton;

    public GameObject ButtonA;
    public GameObject ButtonB;
    public GameObject ButtonC;

    public GameObject CorrectText;
    public GameObject WrongText;

    public GameObject Buttonlabels;
    public GameObject ButtonlabelsContinue;



    public void OnCorrectPressed(){
        ContinueButton.SetActive(true);
        CorrectText.SetActive(true);
        ButtonlabelsContinue.SetActive(true);

        WrongText.SetActive(false);
        ButtonA.SetActive(false);
        ButtonB.SetActive(false);
        ButtonC.SetActive(false);
        Buttonlabels.SetActive(false);
    }

    public void OnIncorrectPressed(){
        WrongText.SetActive(true);
    }
}
