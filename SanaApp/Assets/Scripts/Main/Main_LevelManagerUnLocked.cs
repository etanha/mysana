using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManagerUnLocked : MonoBehaviour {

	[SerializeField]
	private int level;

	[SerializeField]
	public Image Image; 
	public GameObject scenePrefab;
	public GameObject scenePrefabLoad;
	public GameObject Can_Menu;

	void Start () {
		if (PlayerPrefs.GetInt ("Level") >= level) {
			Image.enabled = false;
		}
	}

	public void LevelSelect(){
		Destroy(Can_Menu);
		scenePrefabLoad = Instantiate (scenePrefab) as GameObject;
	}
}
