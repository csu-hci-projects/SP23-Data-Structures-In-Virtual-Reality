using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSolution : MonoBehaviour
{
    public GameObject solution;
    public GameObject ContinueButton;
    public GameObject Cylinder;

    public void toggleSolution(){
        solution.SetActive(!solution.activeSelf);
        ContinueButton.SetActive(!ContinueButton.activeSelf);
    }
    public void GetNewEdge(){
          Instantiate(Cylinder, new Vector3(-0.1527f, 1.2361f, 0.5839f), Quaternion.identity);
    }
}
