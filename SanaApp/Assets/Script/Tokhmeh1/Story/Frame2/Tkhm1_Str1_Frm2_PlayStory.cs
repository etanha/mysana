using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tkhm1_Str1_Frm2_PlayStory : MonoBehaviour {
	public AudioSource audioSource;
	public AudioClip audioClipStory;
	public AudioClip audioClipAdv;
	public AudioClip audioClipQuestion;
	public AudioClip audioClipAlternativTokhme;
	public AudioClip audioClipAlternativBazi;

	public GameObject GOAlternativeBubbleTokhme;
	public GameObject GOAlternativeBubbleBazi;

	public Animator panelZoomAnim;


	void Start () {

		//invisible the alternatives
		GOAlternativeBubbleTokhme.SetActive (false);
		GOAlternativeBubbleBazi.SetActive (false);

		//TV is not zoomed
		panelZoomAnim.SetBool ("isZoomed", false);

		//play story
		audioSource = GetComponent<AudioSource> ();
		StartCoroutine (PlayAudioClipStory());
		/*
		audioSource.time = 32f;
		audioClipStory = audioSource.clip;
		audioSource.Play (); 

		//audioClipStory = audioSource.clip;
		//audioSource.PlayScheduled (32d);

		//play Adv
		audioClipAdv = audioSource.clip;
		audioSource.Play ();
		*/
	}


	void Update () {
		//pakhsh tabligh
		//if (audioSource.time > 95f) {
		/*if (audioSource.time > 38.5f) {
			audioSource.Stop ();
			StartCoroutine (PlayAudioClipQuestion ());
		}*/
	}


	IEnumerator PlayAudioClipStory()
	{
		audioSource.time = 32f;
		audioClipStory = audioSource.clip;
		audioSource.Play (); 

		//audioSource.PlayOneShot (audioClipQuestion);
		yield return new WaitForSeconds (6.5f);
		StartCoroutine (PlayAudioClipAdv ());
	}


	IEnumerator PlayAudioClipAdv()
	{
		
		//audioClipAdv = audioSource.clip;
		//audioSource.Play (); 

		audioSource.PlayOneShot (audioClipAdv);
		yield return new WaitForSeconds (audioClipAdv.length);
		StartCoroutine (PlayAudioClipQuestion ());
	}


	IEnumerator PlayAudioClipQuestion()
	{

		panelZoomAnim.SetBool ("isZoomed", true);

		audioSource.PlayOneShot (audioClipQuestion);
		yield return new WaitForSeconds (audioClipQuestion.length);
		StartCoroutine (PlayAudioClipAlternativTokhme ());
	}


	IEnumerator PlayAudioClipAlternativTokhme()
	{
		GOAlternativeBubbleTokhme.SetActive (true);
		audioSource.PlayOneShot (audioClipAlternativTokhme);
		yield return new WaitForSeconds (audioClipAlternativTokhme.length);
		StartCoroutine (PlayAudioClipAlternativBazi ());
	}


	IEnumerator PlayAudioClipAlternativBazi()
	{
		GOAlternativeBubbleBazi.SetActive (true);
		audioSource.PlayOneShot (audioClipAlternativBazi);
		yield return new WaitForSeconds (audioClipAlternativBazi.length);
	}
}
