using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Player_Control : MonoBehaviour {

	public Canvas Canvas_Menu_Player;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3(0, 0, 0);

	}
	
	// Update is called once per frame
	void Update () {

		Vector3 Mag;

		Mag.x = (0);
		Mag.y = (0);
		Mag.z = (0);

		float Mod = (0);

		if (Input.GetKey (KeyCode.LeftShift)) {
			Mod = (2);
		} else {
			Mod = (1);
		}

		if (Input.GetKey (KeyCode.W)) {
			Mag.y = (.1F) * (Mod);
		} else if (Input.GetKey (KeyCode.S)) {
			Mag.y = (-.1F) * (Mod);
		} else {
			Mag.y = (0);
		}

		if (Input.GetKey (KeyCode.D)) {
			Mag.x = (.1F) * (Mod);
		} else if (Input.GetKey (KeyCode.A)) {
			Mag.x = (-.1F) * (Mod);
		} else {
			Mag.x = (0);
		}

		transform.Translate (Mag);

		if (Input.GetKey (KeyCode.Escape)) {
			Canvas_Menu_Player.enabled = true;
		}
	}
}
