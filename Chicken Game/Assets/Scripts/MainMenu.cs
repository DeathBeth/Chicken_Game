using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// public void PlayGame(){
	// 	SceneManager.LoadScene(1);
	// }


	public int levelToLoad;



	public void LoadLevel(){
		SceneManager.LoadScene(levelToLoad);
	}

	public void LevelExit(){
		Debug.Log("Game Quit");
		Application.Quit();
	}
}
