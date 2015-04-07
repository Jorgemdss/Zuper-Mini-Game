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

	//string[] myWords = new string[]{"bota","pato","juba","tampa","vela"};

	public ArrayList myWordArray = new ArrayList();//usar o count em vez de lenght
	 
	public GameObject[] letterGroupList1 = new GameObject[2];
	public GameObject[] letterGroupList2 = new GameObject[2];
	public GameObject[] listToSummon = new GameObject[5];


	public GameObject myRandomObject;



	void Start () {
		AssignWordGroupsArrayList ();
		MakeItRain ();
		listToSummon = letterGroupList1;



	}
	

	void Update () {
		CheckWordPickList ();
		Debuger();

		myRandomObject = listToSummon [Random.Range (0, listToSummon.Length)];


	}




	void LaunchProjectileLane1()
	{
		CheckWordPickList ();
		GameObject randomInstance = (GameObject)Instantiate (myRandomObject, spawn1.transform.position, Quaternion.identity);

	}
	void LaunchProjectileLane2()
	{
		CheckWordPickList ();

		GameObject randomInstance = (GameObject)Instantiate (myRandomObject, spawn2.transform.position, Quaternion.identity);
	}

	void LaunchProjectileLane3()
	{
		CheckWordPickList ();

		GameObject randomInstance = (GameObject)Instantiate (myRandomObject, spawn3.transform.position, Quaternion.identity);
		
	}

	void MakeItRain ()
	{
		InvokeRepeating ("LaunchProjectileLane1",1 , 2);
		InvokeRepeating ("LaunchProjectileLane2",2 , 2);
		InvokeRepeating ("LaunchProjectileLane3", 2.7f, 2);
	}

	void Debuger()
	{
		if (Input.GetKeyUp (KeyCode.Z)) 
		{

			//object myRandomWord = myWordArray [Random.Range (0, myWordArray.Count)];
			//print (myRandomWord.ToString());
			for (int i = 0; i <myWordArray.Count; i++) 
			{
				print (myWordArray[i]);	
			}
			print ("*******************");
		}

		if (Input.GetKeyUp (KeyCode.X)) 
		{
			myWordArray.RemoveAt(0);//tira no index
			myWordArray.Remove("bota");//tira na string
		}
	}

	void CheckWordPickList()
	{
		if (GameManager.wantedWord == "vela") 
		{
			GameObject myRandomObject =  letterGroupList1 [Random.Range (0, letterGroupList1.Length)];
		}

		if (Input.GetKeyUp (KeyCode.U)) 
		{
			listToSummon = letterGroupList2;

		}

	}


	void AssignWordGroupsArrayList()
	{
		// fazer um switch (level)
		myWordArray.Add ("bota");
		myWordArray.Add ("pato");
		myWordArray.Add ("juba");
		myWordArray.Add ("tampa");
		myWordArray.Add ("vela");
	}





}
