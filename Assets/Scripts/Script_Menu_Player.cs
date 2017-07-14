using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Script_Menu_Player : MonoBehaviour {

	public Canvas Canvas_Menu_Player;

	void Awake (){
		Canvas_Menu_Player.enabled = false;
	}

	public void displayMenuPlayer(){
		Canvas_Menu_Player.enabled = true;
	}

	public void disableMenuPlayer(){
		Canvas_Menu_Player.enabled = false;
	}

	public void loadSceneMenuMain(){
		SceneManager.LoadScene ("Menu_Main");
	}
}
