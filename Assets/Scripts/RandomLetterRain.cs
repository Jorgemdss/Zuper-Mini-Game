using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomLetterRain : MonoBehaviour {

	/* 
	 * ESTE CODIGO TRATA DE FAZER CAIR AS LETRA EM RANDOM
	 * (vamos ter grupos de letras, portanto tenho de fazer um array de gameobjects)
	 * meto assim. grupo 1 [A,B ,C]  | grupo2[A,L,CH] etc etc... 
	 */

	public GameObject spawn1;
	public GameObject spawn2;
	public GameObject spawn3;

	string[] myWords = new string[]{"rip","in","peace","mate"};
	
	//public List<GameObject> minhaLista = new List <GameObject> ();

	public GameObject[] letterWordList1 = new GameObject[4];
	public GameObject listToBeInstantiated;
	public GameObject myRandomObject;

	public GameObject letterObject;
	public GameObject letterObject2;


	void Start () {




		MakeItRain ();

	}
	

	void Update () {

		myRandomObject = letterWordList1 [Random.Range (0, letterWordList1.Length)];
		listToBeInstantiated = myRandomObject;



	
	}


	void LaunchProjectileLane1()
	{
		GameObject myRandomObject = letterWordList1 [Random.Range (0, letterWordList1.Length)];
		GameObject randomInstance = (GameObject)Instantiate (listToBeInstantiated, spawn1.transform.position, Quaternion.identity);

	}
	void LaunchProjectileLane2()
	{
		GameObject myRandomObject = letterWordList1 [Random.Range (0, letterWordList1.Length)];

		GameObject letterE = (GameObject)Instantiate (listToBeInstantiated, spawn2.transform.position, Quaternion.identity);
	}

	void LaunchProjectileLane3()
	{
		GameObject myRandomObject = letterWordList1 [Random.Range (0, letterWordList1.Length)];

		GameObject letterE = (GameObject)Instantiate (listToBeInstantiated, spawn3.transform.position, Quaternion.identity);
		
	}

	void MakeItRain ()
	{
		InvokeRepeating ("LaunchProjectileLane1",1 , 2);
		InvokeRepeating ("LaunchProjectileLane2",2 , 2);
		InvokeRepeating ("LaunchProjectileLane3", 2.7f, 2);
	}

	void RainRandomLetter()
	{
		if (Input.GetKeyUp (KeyCode.Z)) 
		{
			//string myRandomWord = myWords [Random.Range (0, myWords.Length)];
			
			//print (myRandomWord);

			GameObject myRandomObject = letterWordList1 [Random.Range (0, letterWordList1.Length)];
			print (myRandomObject);

		}
	}





}
