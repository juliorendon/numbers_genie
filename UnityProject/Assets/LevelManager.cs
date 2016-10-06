﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log ("Request Level: " + name);
		//Application.LoadLevel (name);
		SceneManager.LoadScene (name);
	}

	public void Quit() {
		Debug.Log ("Quit game requested");
		Application.Quit();
	}
}
