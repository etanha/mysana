using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tkm1_Gm2_Main : MonoBehaviour {

//	public GameObject Img_Egg_Fake_ForGround1;
//	public GameObject Img_Egg_Original_ForGround1;

	public Image Img_Egg_Fake_ForGround;
	public Image Img_Egg_Original_ForGround;

	public AudioSource audioSource;
	public AudioClip audioClipQuestionGm2;

/*
	public GameObject GObject_Egg_Fake;
	public List <Animator> Fake_wrongAnswerAnim = new List<Animator>(3);
	public List <Animator> Original_RightAnswerAnim = new List<Animator>(2);
*/

	//lazem darim ta dar safhe  bashanad
	public Image Img_FDA_Logo;
	public Image Img_Standard_Logo;
	public Image Img_Candy_Fake_Shaking;

	void Start () {

		//agar chand bar vared in tamrin shod meghdar PlayerPrefs ghabli pak shavad
		PlayerPrefs.DeleteKey ("Tkhm1_Gm2_PlayingQuestionFinished");
		audioSource = GetComponent<AudioSource> ();
		Img_FDA_Logo.enabled = false;
		Img_Standard_Logo.enabled = false;
		Img_Candy_Fake_Shaking.enabled = false;

		StartCoroutine (PlayQuestion());
	}


	IEnumerator	PlayQuestion()
	{

		audioSource.PlayOneShot (audioClipQuestionGm2);
		yield return new WaitForSeconds (audioClipQuestionGm2.length);
		PlayerPrefs.SetInt ("Tkhm1_Gm2_PlayingQuestionFinished", 2);

	}


}
