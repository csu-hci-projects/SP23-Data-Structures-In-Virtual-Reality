using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneOneName;
	public void ChangeSceneOne()
	{
		SceneManager.LoadScene(sceneOneName);
	}
	public void Exit()
	{
		Debug.Log("[CHANGE SCENE]: SHOULD EXIT");
		Application.Quit();
		UnityEditor.EditorApplication.isPlaying = false;
	}
}