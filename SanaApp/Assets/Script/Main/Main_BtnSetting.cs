using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_BtnSetting : MonoBehaviour {
	[SerializeField]
	private int ReleazedLevel;
	public GameObject Can_Next = null;
	public GameObject Can_Back = null;

	public GameObject scenePrefabLoad = null;
	public GameObject Can_this = null;

	//public Animator[] Animators;

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


		if (Can_this.GetComponent<AudioSource> () != null) {
			Can_this.GetComponent<AudioSource> ().Stop ();
		}

		/*for (int i = 0; i < Animators.Length; i++) {
			Animators [i].Rebind ();
			Animators [i].enabled = false;
			Debug.Log (Animators [i]);
		}*/

		StartCoroutine (FadeInAnim(1));
	}

	public void GoToBackLevel(){
		StartCoroutine (FadeInAnim(0));
	}

	IEnumerator FadeInAnim(int Next_Back){
		ObjAnim.GetComponent<Animator> ().Play ("FeatherAnim01");
		yield return new WaitForSeconds (2.30f);
		Destroy (Can_this);
		if (Next_Back == 1) {
			scenePrefabLoad = Instantiate (Can_Next) as GameObject;
			Canvas can = Can_Next.GetComponent<Canvas> ();
			can.worldCamera = MainCamera;
		} else {
			scenePrefabLoad = Instantiate (Can_Back) as GameObject;
			Canvas can = Can_Next.GetComponent<Canvas> ();
			can.worldCamera = MainCamera;
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
