using UnityEngine;
using System.Collections;

public class RandomLetterRain : MonoBehaviour {


	public GameObject spawn1;
	public GameObject spawn2;
	public GameObject spawn3;



	public GameObject letterObject;
	public GameObject letterObject2;


	void Start () {

		MakeItRain ();


	}
	

	void Update () {


	
	}

	void LaunchProjectileLane1()
	{
		GameObject letterA = (GameObject)Instantiate (letterObject, spawn1.transform.position, Quaternion.identity);


	}
	void LaunchProjectileLane2()
	{
		GameObject letterE = (GameObject)Instantiate (letterObject2, spawn2.transform.position, Quaternion.identity);
		
	}

	void LaunchProjectileLane3()
	{
		GameObject letterE = (GameObject)Instantiate (letterObject2, spawn3.transform.position, Quaternion.identity);
		
	}

	void MakeItRain ()
	{
		InvokeRepeating ("LaunchProjectileLane1",1 , 2);
		InvokeRepeating ("LaunchProjectileLane2",2 , 2);
		InvokeRepeating ("LaunchProjectileLane3", 2.7f, 2);
	}



}
