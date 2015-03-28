using UnityEngine;
using System.Collections;

public class AlphabetValueManager : MonoBehaviour {

	public GameObject A;
	public static string aValue;


	void Start () {

		aValue = A.transform.name;
	
	}
	

	void Update () {

	
	}
}
