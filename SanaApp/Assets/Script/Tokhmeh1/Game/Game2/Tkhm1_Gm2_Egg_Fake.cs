using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tkhm1_Gm2_Egg_Fake : MonoBehaviour {

	//lazem darim ta az safhe hazf shavand
	public GameObject GObject_Egg_Original;
	public Image Img_Egg_Fake_ForGround;

	//lazem darim ta dar safhe zaher shavand
	public Image Img_FDA_Logo;
	public Image Img_Standard_Logo;

	//soal tavajoh b alamathaye Standard & FDA
	public AudioSource audioSource;
	public AudioClip audioClipQuestion_Standard_Logo;
	public AudioClip audioClipQuestion_FDA_Logo;

	//array az animiations FDA &Standard Logos & Insinde the egg
	public List <Animator> Fake_wrongAnswerAnim; 
	public GameObject[] Elements;

	void start ()
	{
		//dar ebteda' FDA va Standard ra namayesh nade
		Img_FDA_Logo.enabled = false;
		Img_Standard_Logo.enabled = false;

		//eghdar dehi array of animations
		Fake_wrongAnswerAnim = new List<Animator> ();
		for (int i=0;i<Elements.Length;i++)
			Fake_wrongAnswerAnim.Add(Elements[i].GetComponent<Animator>());

		audioSource = GetComponent<AudioSource> ();

	}

	public void OnClick_Egg_Fake()
	{
		Img_Egg_Fake_ForGround.enabled = false;

		//hazf original az safhe
		GObject_Egg_Original.SetActive (false);


		//mohtaviat fake birun berizad
		Fake_wrongAnswerAnim[0].SetBool ("WrongAnswerIn_Egg_Fake",true);

		//play animation and sound Standard Logo
		StartCoroutine (WaitForFinishingAnimationIn_Egg_Fake ());
	}


	IEnumerator WaitForFinishingAnimationIn_Egg_Fake()
	{
		RuntimeAnimatorController ac = Fake_wrongAnswerAnim[0].runtimeAnimatorController;

		yield return new WaitForSeconds (ac.animationClips.Length);
		StartCoroutine (PlayAudioClipQuestionAndAnim_Standard_Logo ());
	}
		

	IEnumerator PlayAudioClipQuestionAndAnim_Standard_Logo()
	{
		Img_Standard_Logo.enabled = true;

		//play animation Standard Logo
		Fake_wrongAnswerAnim[1].SetBool ("WrongAnswerStandard_Logo",true);

		// play Standardclip
		audioSource.PlayOneShot (audioClipQuestion_Standard_Logo);

		//wait for playing Standardclip
		yield return new WaitForSeconds (audioClipQuestion_Standard_Logo.length);
		//after Standardclip finished , play FDA clip
		StartCoroutine (PlayAudioClipQuestionAndAnim_FDA_Logo ());
	}

	IEnumerator PlayAudioClipQuestionAndAnim_FDA_Logo()
	{
		Img_FDA_Logo.enabled = true;

		//play animation FDA Logo
		Fake_wrongAnswerAnim[2].SetBool ("WrongAnswerFDA_Logo",true);

		// play FDAclip
		audioSource.PlayOneShot (audioClipQuestion_FDA_Logo);
		//wait for playing FDAclip
		yield return new WaitForSeconds (audioClipQuestion_FDA_Logo.length);


	}
}
