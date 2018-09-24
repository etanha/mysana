using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tkhm1_Str1_Frm2_PlayStory : MonoBehaviour {
	public AudioSource audioSource;
	public AudioClip audioClipStory;
	public AudioClip audioClipQuestion;
	public AudioClip audioClipAlternativTokhme;
	public AudioClip audioClipAlternativBazi;

	public GameObject GOAlternativeBubbleTokhme;
	public GameObject GOAlternativeBubbleBazi;

	public Animator panelZoomAnim;


	void Start () {
		//play story
		audioSource = GetComponent<AudioSource> ();
		audioSource.time = 48f;
		audioClipStory = audioSource.clip;
		audioSource.Play ();

		//invisible the alternatives
		GOAlternativeBubbleTokhme.SetActive (false);
		GOAlternativeBubbleBazi.SetActive (false);

		//TV is not zoomed
		panelZoomAnim.SetBool ("isZoomed", false);

	}
	


	void Update () {
		//if (audioSource.time > 95f) {
		if (audioSource.time > 55f) {
			audioSource.Stop ();
			StartCoroutine (PlayAudioClipQuestion ());
		}
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
