using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tkhm1_Gm2_Egg_Original : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip audioClipRightAnswer;

	//hazf fake az safhe
	public Image Img_Egg_Original_ForGround;

	public GameObject GObject_Egg_Fake;
	public Animator Original_rightAnswerAnim;

	public void OnClick_Egg_Original()
	{
		if (PlayerPrefs.GetInt ("Tkhm1_Gm2_PlayingQuestionFinished") == 2) {
			audioSource = GetComponent<AudioSource> ();

			Img_Egg_Original_ForGround.enabled = false;

			//hazf fake az safhe
			GObject_Egg_Fake.SetActive (false);

			audioSource.PlayOneShot (audioClipRightAnswer);

			//play animations
			Original_rightAnswerAnim.SetBool ("RightAnswerIn_Egg_Original", true);

		}
	}
		
}
