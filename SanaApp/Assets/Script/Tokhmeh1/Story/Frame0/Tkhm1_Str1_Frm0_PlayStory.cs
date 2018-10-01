using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tkhm1_Str1_Frm0_PlayStory : MonoBehaviour {

	public AudioSource audioSource;

	public GameObject scenePrefab;
	public GameObject scenePrefabLoad;
	public GameObject Can_Menu;

	Camera MainCamera;
	GameObject ObjAnim;

	void Start () {
		MainCamera = GameObject.Find ("Main Camera").GetComponent<Camera>();
		ObjAnim = GameObject.Find("Can_BetweenFrame");
		audioSource = GetComponent<AudioSource> ();
		StartCoroutine (PlayAudioClipStory ());
	}
	
	IEnumerator PlayAudioClipStory()
	{
		yield return new WaitForSeconds (24.792f);
		StartCoroutine (FadeInAnim());


	}

	IEnumerator FadeInAnim(){
		
		ObjAnim.GetComponent<Animator> ().Play ("FeatherAnim01");
		yield return new WaitForSeconds (2.30f);
		Destroy(Can_Menu);
		Canvas can = scenePrefab.GetComponent<Canvas>();
		can.worldCamera = MainCamera;
		scenePrefabLoad = Instantiate (scenePrefab) as GameObject;

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
