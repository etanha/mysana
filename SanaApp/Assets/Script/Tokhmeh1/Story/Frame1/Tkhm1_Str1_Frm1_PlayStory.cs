using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tkhm1_Str1_Frm1_PlayStory : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip audioClipStoryFrm1;

	//public Animator[] Animations;

	// Use this for initialization
	void Start () {
		//for(int i=0; i<Animations;)
		audioSource = GetComponent<AudioSource> ();

		audioClipStoryFrm1 = audioSource.clip;
		audioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
		if (audioSource.time>48f)
			audioSource.Stop ();
	}
		
}
