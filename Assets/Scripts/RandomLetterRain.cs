using UnityEngine;
using System.Collections;

public class RandomLetterRain : MonoBehaviour {


	public GameObject spawn1;
	public GameObject spawn2;
	public GameObject spawn3;

	public GameObject letterObject;


	void Start () {
		MakeItRain ();
	
	}
	

	void Update () {

	
	}

	void LaunchProjectile()
	{
		GameObject letterA = (GameObject)Instantiate (letterObject, spawn1.transform.position, Quaternion.identity);

	}

	void MakeItRain ()
	{
		InvokeRepeating ("LaunchProjectile", 1, 2);
	}
}
