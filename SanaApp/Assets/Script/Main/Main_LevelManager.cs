using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main_LevelManager : MonoBehaviour {
	[SerializeField]
	private int level;

	[SerializeField]
	public GameObject scenePrefab;
	public GameObject scenePrefabLoad;
	public GameObject Can_Menu;
	public string SelectBookBool;

	Camera MainCamera;
	Animator BookAnim;

	void Start () {
		
		MainCamera = GameObject.Find ("Main Camera").GetComponent<Camera>();
		BookAnim = GameObject.Find ("BG").GetComponent<Animator>();

		Debug.Log (PlayerPrefs.GetInt ("Level").ToString ());
		string level = PlayerPrefs.GetInt ("Level").ToString (); 
		//BookAnim.SetBool ("MenuPage1Book" + level + "Read");
		
	}

	public void LevelSelect(){
		StartCoroutine (BookStart());
	}

	IEnumerator BookStart(){
		BookAnim.SetBool(SelectBookBool, true);
		yield return new WaitForSeconds (4f);

		Destroy(Can_Menu);
		Canvas can = scenePrefab.GetComponent<Canvas>();
		can.worldCamera = MainCamera;
		scenePrefabLoad = Instantiate (scenePrefab) as GameObject;

	}
}
