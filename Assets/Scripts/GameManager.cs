using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {
	/*
	 * o game manager e o main script disto, aqui controlo colisoes, movimentos, pontos, engeria, e outra vars	 * 
	 */


	public GameObject word;
	public GameObject livesText;
	public AudioSource mainMusic;

	public static string wantedWord;
	public static string wantedLetter;

	public static int lives;


	void Start () {
		wantedWord = "VELA";
		lives = 3;


		livesText.GetComponent<Text> ().text = lives.ToString();


	
	}
	

	void Update () {

		if (wantedWord =="VELA")wantedLetter = "A";


		GameOver();	

		WordCompleter ();

			


	
	}

	void WordCompleter()
	{
		if (wantedLetter == CharController.myLetterValue) {
			word.GetComponent<Text> ().text = "V E L " + CharController.myLetterValue;
			Debug.Log ("you win");
		} else if (CharController.myLetterValue !=  "_")
		{
			Debug.Log("apanhou letra errada");
			lives--;
			livesText.GetComponent<Text> ().text = lives.ToString();
			CharController.myLetterValue = "_";
		}
	}

	public void PauseMenu()
	{
		Time.timeScale = 0;
	}

	public void ReseGameDebug()
	{
		Application.LoadLevel("Main");
		lives = 3;
		Time.timeScale = 1;
	}

	void GameOver()
	{
		if (lives <= 0) 
		{
			Debug.Log ("Game Over");
			Time.timeScale = 0;
			mainMusic.Stop ();
			livesText.GetComponent<Text> ().text = "Game Over";
		}
	}

}
