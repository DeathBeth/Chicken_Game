using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

	public static int score;
	public int winScore;
	public Text text;
	public Text winText;

	void Awake(){
		Time.timeScale = 1;
	}
	void Start () {
		winText.GetComponent<Text>().enabled = false;
		text = GetComponent<Text>();
			score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(score < 0)
			score = 0;

		text.text =" " + score;

		//If the player wins, display win text

			if(score >= winScore){
			print("Win score reached = " + score);
			winText.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}
			if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(0);
			}
		
	}
	

	public static void AddPoints(int pointsToAdd){
		score += pointsToAdd;
	}
	public static void MinusPoints(int pointsToMinus){
		score -= pointsToMinus;
	}

	public void Reset(){
		score=0;
	}
}
