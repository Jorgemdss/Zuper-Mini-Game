using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestWords : MonoBehaviour {


	public string minhaStringValor;
	public string minhaStringChave;
	Dictionary <string,string> myDictionary = new Dictionary<string, string >();

	// @Daniel convem ter apenas 2 strings estaticas em vez desta trapalhada?? ex: chavePalavra >>>  palavraIncompleta (se true, passar proxima)
	void Start () {

		minhaStringChave = "chave";
		minhaStringValor = "valor";



		myDictionary.Add (minhaStringChave,minhaStringValor);//eu podia ter 1 para cada palavra @Daniel
		//myDictionary.Add ("cao","gato");

		//myDictionary["chave"] = "arrow";//isto e um indexer, eu ponho a key que quero e troco o valor
		Debug.Log (myDictionary.Count);



		if (myDictionary.ContainsKey ("chave")) //pega na chave e da o valor do "value" SE a key for a "chave", ya ele vai buscar o valor da chave "chave"
		{
			//Debug.Log(myDictionary["chave"]);
		}

		//agora pego no valor e da a chave

		if (myDictionary.ContainsValue ("valor")) 
		{
			//Debug.Log("valor true");
		}
	
	}
	
	void Update () {
		if (Input.GetKey (KeyCode.P)) 
		{
			minhaStringValor = "chave";
			myDictionary["chave"] = minhaStringValor;//nao esquecer que tenho de fazer o update a isto, senao nao funciona
			Debug.Log (myDictionary["chave"]);
		}

		if (Input.GetKey (KeyCode.O)) 
		{

			minhaStringChave = "outraChave";
			myDictionary.Add (minhaStringChave,minhaStringValor);//isto funciona mas da erro, @Daniel como se muda a key ou se esta e a melhor coleçao
		}


		CheckIfWordsMatch ();//nao sei se ter um foreach no update e boa ideia. @Daniel

	
	}

	void CheckIfWordsMatch()
		//este codigo compara os pares, e se forem true entao eu executo o pedaço de codigo que quero, neste caso
		//posso ter uma funçao que vai tratar dos pontos, proxima palavra, animaçao
		//nao esquecer que a palavra e random
	{
		foreach (KeyValuePair<string,string> pair in myDictionary) 
		{
			//string entry = pair.Key + " = " + pair.Value;
			if (Input.GetKey(KeyCode.O))Debug.Log(pair.Key);
			
			if (pair.Key == pair.Value) // eu posso usar isto para ver se as palavras sao iguais
			{
				Debug.Log("iguais");
			}else
			{
				//Debug.Log("diferentes");
			}
		}
	}
}
