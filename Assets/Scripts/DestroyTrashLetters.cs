using UnityEngine;
using System.Collections;

public class DestroyTrashLetters : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if (GameObject.FindWithTag ("Letter")) 
		{
			Destroy(col.gameObject);
		}
	}
}
