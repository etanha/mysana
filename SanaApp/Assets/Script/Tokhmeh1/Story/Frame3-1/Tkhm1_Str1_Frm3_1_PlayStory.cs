using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tkhm1_Str1_Frm3_1_PlayStory : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip audioClipStoryFrm3_1;


	void Start ()
	{
		audioSource = GetComponent<AudioSource> ();

		audioSource.time = 34f;
		audioClipStoryFrm3_1 = audioSource.clip;
		audioSource.Play();
	}
	
	void Update () {
		if (audioSource.time>78f)
			audioSource.Stop ();
	}
}
