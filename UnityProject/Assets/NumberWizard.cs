using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;
	int maxGuesses = 13;
	List<int> guessedNumbers = new List<int> ();

	public Text textGuess;
	public Text remainingGuesses;

	// Use this for initialization
	void Start () {
		StartGame ();
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	public void GuessHigher() {
		min = guess;
		NextGuess ();
	}

	public void GuessLower() {
		max = guess;
		NextGuess ();
	}

	private void NextGuess() {
		guess = Random.Range(min, max); 

		if (guessedNumbers.Contains (guess)) {
			while (guessedNumbers.Contains (guess)) {
				guess = Random.Range(min, max); 
			}
		}

		guessedNumbers.Add (guess);

		//guess = (max + min) / 2;
		maxGuesses--;
		setRemainingGuesses ();

		textGuess.text = guess.ToString();

		if (maxGuesses <= 0) {
			SceneManager.LoadScene ("Win");
		}
	}

	private void setRemainingGuesses() {
		remainingGuesses.text = "Remaining Guesses: " + maxGuesses;
	}

	void StartGame() {
		max = 1000;
		min = 1;
		guess = max / 2;
		max++;
		guessedNumbers.Add (guess);
	}


}
