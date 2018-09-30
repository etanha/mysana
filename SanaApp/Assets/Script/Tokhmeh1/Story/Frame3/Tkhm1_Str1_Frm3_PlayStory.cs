using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tkhm1_Str1_Frm3_PlayStory : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip audioClipStoryFrm3;


	void Start () 
	{
		audioSource = GetComponent<AudioSource> ();

		audioClipStoryFrm3 = audioSource.clip;
		audioSource.Play();
	}
	

	void Update () {
	//stop dar payan bakhsh alef az frame 3
		if (audioSource.time>34f)
			audioSource.Stop ();
	}
}
