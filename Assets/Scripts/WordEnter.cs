using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordEnter : MonoBehaviour
{
    public string newWord;
    public GameObject inputField;
     // public GameObject textDisplay;

    public void StoreWord(){
        Debug.Log("[Word Enter]: Pressed Enter");
        newWord = inputField.GetComponent<Text>().text;
        Debug.Log("[Word Enter]: " + newWord);
    }

}
