using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main_LevelManager : MonoBehaviour {
	[SerializeField]
	private int level;

	[SerializeField]
	public Image Image; 
	public GameObject scenePrefab;
	public GameObject scenePrefabLoad;
	public GameObject Can_Menu;

	Camera MainCamera;

	void Start () {
		MainCamera = GameObject.Find ("Main Camera").GetComponent<Camera>();
		if (PlayerPrefs.GetInt ("Level") >= level) {
			Image.enabled = false;
		}
	}

	public void LevelSelect(){
		Destroy(Can_Menu);
		scenePrefabLoad = Instantiate (scenePrefab) as GameObject;
		Canvas can = scenePrefab.GetComponent<Canvas>();
		can.worldCamera = MainCamera;
	}
}
