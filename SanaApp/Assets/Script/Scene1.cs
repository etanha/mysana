using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1 : MonoBehaviour {
	[SerializeField]
	private AudioSource audioSource;
	public GameObject Load_MusicImage;

	void Start () {
		Load_MusicImage.SetActive (false);
		StartCoroutine(showPlay());
	}

	IEnumerator showPlay(){
		yield return new WaitForSeconds (15.869f);
		Load_MusicImage.SetActive (true);
	}
}
