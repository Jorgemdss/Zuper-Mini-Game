using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	//public GameObject A;
	//public static string aValue;

	public GameObject word;
	public GameObject livesText;

	public string wantedWord;
	public string wantedLetter;

	public static int lives;


	void Start () {
		wantedWord = "Vela";
		lives = 3;


		livesText.GetComponent<Text> ().text = lives.ToString();

		//aValue = A.transform.name;

	
	}
	

	void Update () {

		if (wantedWord =="Vela")wantedLetter = "a";
		if (lives <= 0) 
		{
			//gameOver();
			Debug.Log("Game Over");
			//Time.timeScale= 0;
		}

		WordCompleter ();

			


	
	}

	void WordCompleter()
	{
		if (wantedLetter == CharController.myLetterValue) {
			word.GetComponent<Text> ().text = "V e l " + CharController.myLetterValue;
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

}
