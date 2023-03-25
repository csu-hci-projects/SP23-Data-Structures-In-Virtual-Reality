using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class QuestionButtonPress : MonoBehaviour
{
    public GameObject ContinueButton;
    public GameObject ButtonA;
    public GameObject ButtonB;
    public GameObject ButtonC;


    public string ButtonAText;
    public string ButtonBText;
    public string ButtonCText;


    public GameObject PromptText;
    public TMP_Text TextField;
 
    public string ButtonAText_labels;
    public string ButtonBText_labels;
    public string ButtonCText_labels;

    public TMP_Text ButtonLabel;

    void setText(string button){
        string prompt_text = "";
        string buttonLabelText = "";
        switch(button) {
            case "A":
            prompt_text = ButtonAText;
            buttonLabelText = ButtonAText_labels;
            break;
            case "B":
            prompt_text = ButtonBText;
            buttonLabelText = ButtonBText_labels;
            break;
            case "C":
            prompt_text = ButtonCText;
            buttonLabelText = ButtonCText_labels;
            break;
             default:
                // code block
             break;
        }
        TextField.text = prompt_text;
        ButtonLabel.text = buttonLabelText;
    }

    public void Correct(string button){
       setText(button);

        ContinueButton.SetActive(true);
        PromptText.SetActive(true);
        ButtonA.SetActive(false);
        ButtonB.SetActive(false);
        ButtonC.SetActive(false);

    }

    public void Incorrect(string button){
        PromptText.SetActive(true);
        setText(button);
    }
}
