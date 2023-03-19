using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordEnter : MonoBehaviour
{
    public string newWord;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreWord(){
        newWord = inputField.GetComponent<Text>().text;
         Debug.Log("[Word Enter]: " + newWord);
    }

}
