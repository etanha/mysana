using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	void Start(){
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
			#else
			Application.Quit();
			#endif
		}
	}

}
