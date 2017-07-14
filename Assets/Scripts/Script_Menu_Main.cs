using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Script_Menu_Main : MonoBehaviour {

	public Canvas Canvas_Menu_Main;
	public Canvas Canvas_Menu_Settings;

	void Awake() {
		Canvas_Menu_Main.enabled = true;
		Canvas_Menu_Settings.enabled = false;
	}

	public void displayMenuMain() {
		Canvas_Menu_Main.enabled = true;
		Canvas_Menu_Settings.enabled = false;
	}

	public void displayMenuSettings() {
		Canvas_Menu_Main.enabled = false;
		Canvas_Menu_Settings.enabled = true;
	}

	public void loadSceneWorldMain() {
		SceneManager.LoadScene ("World_Main");
	}

	public void toggleSound() {
		if (Variables_Application.enableSound == true) {
			Variables_Application.enableSound = false;
		} else {
			Variables_Application.enableSound = true;
		}
	}

	public void toggleMusic() {
		if (Variables_Application.enableMusic == true) {
			Variables_Application.enableMusic = false;
		} else {
			Variables_Application.enableMusic = true;
		}
	}

	public void gameEnd() {
		Application.Quit ();
	}
}
