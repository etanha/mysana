﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Main_BtnSetting : MonoBehaviour {
	[SerializeField]
	private int ReleazedLevel;
	public GameObject Can_Next = null;
	public GameObject Can_Back = null;

	public GameObject scenePrefabLoad = null;
	public GameObject Can_this = null;

	public AudioSource[] audioSource; 

	public VideoPlayer[] videoPlayer;

	GameObject ObjAnim;
	Animator TransAnim;
	Camera MainCamera;

	void Start () {
		//PlayerPrefs.DeleteAll ();
		ObjAnim = GameObject.Find("Can_BetweenFrame");
		MainCamera = GameObject.Find ("Main Camera").GetComponent<Camera>();
	}

	public void GoToMenu(){
		Destroy(Can_this);
		scenePrefabLoad = Instantiate (Resources.Load("Prefabs/Can_Menu")) as GameObject;
	}

	public void GoToNextLevel(){
		PlayerPrefs.SetInt ("Level",ReleazedLevel);

		for (int a = 0; a < audioSource.Length; a++) {
			if (audioSource[a] != null) {
				audioSource[a].Stop();
			}
		}

		for (int v = 0; v < videoPlayer.Length; v++) {
			if (videoPlayer[v] != null) {
				videoPlayer[v].Stop();
			}
		}

		StartCoroutine (FadeInAnim(1));
	}

	public void GoToBackLevel(){
		for (int a = 0; a < audioSource.Length; a++) {
			if (audioSource[a] != null) {
				audioSource[a].Stop();
			}
		}

		for (int v = 0; v < videoPlayer.Length; v++) {
			if (videoPlayer[v] != null) {
				videoPlayer[v].Stop();
			}
		}

		StartCoroutine (FadeInAnim(0));
	}

	IEnumerator FadeInAnim(int Next_Back){
		ObjAnim.GetComponent<Animator> ().Play ("FeatherAnim01");
		yield return new WaitForSeconds (2.30f);
		Destroy (Can_this);
		if (Next_Back == 1) {
			Canvas can = Can_Next.GetComponent<Canvas> ();
			can.worldCamera = MainCamera;
			scenePrefabLoad = Instantiate (Can_Next) as GameObject;
		} else {
			Canvas can = Can_Back.GetComponent<Canvas> ();
			can.worldCamera = MainCamera;
			scenePrefabLoad = Instantiate (Can_Back) as GameObject;
		}

		FadeOut ();
	}

	void FadeOut(){
		StartCoroutine (FadeOutAnim());
	}

	IEnumerator FadeOutAnim(){
		ObjAnim.GetComponent<Animator> ().Play ("FeatherAnim70");
		yield return new WaitForSeconds (2f);
	}
}
