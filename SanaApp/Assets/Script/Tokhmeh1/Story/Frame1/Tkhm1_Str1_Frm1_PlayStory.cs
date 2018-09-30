using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tkhm1_Str1_Frm1_PlayStory : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip audioClipStoryFrm1;


	void Start () {
		
		audioSource = GetComponent<AudioSource> ();

		audioSource.time =3.5f;
		audioClipStoryFrm1 = audioSource.clip;
		audioSource.Play();
	}
	

	void Update () {
		if (audioSource.time>48f)
			audioSource.Stop ();
	}
		
}
