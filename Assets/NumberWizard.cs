using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess;
	public int maxcount=10;

	public Text text;

	void Start () {
		StartGame ();
		}
	void StartGame (){
		max = 1000;
		min = 1;
		guess = Random.Range(min,max+1) ;
		text.text = guess.ToString ();

	}


	public void GuessHigher(){
		min = guess;
		NextGuess ();
	}

	public void GuessLower(){
		max = guess;
		NextGuess ();
	}

	void NextGuess(){
		guess = Random.Range( min , max + 1 );
		text.text = guess.ToString ();
		maxcount = maxcount - 1;
		if (maxcount <= 0) {
			Application.LoadLevel ("Win");
		}
	}
}
