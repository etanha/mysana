using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tkhm1_Gm2_Egg_Fake : MonoBehaviour {

	//lazem darim ta az safhe hazf shavand
	public GameObject GObject_Egg_Original;
	public Image Img_Egg_Fake_ForGround;
	public Image Img_Candy_Fake;

	//lazem darim ta dar safhe zaher shavand
	public Image Img_FDA_Logo;
	public Image Img_Standard_Logo;
	public Image Img_Candy_Fake_Shaking;

	// tavajoh b nokat entekhab dorost mesl alamathaye Standard & FDA
	public AudioSource audioSource;
	public AudioClip audioClipWrongAnswer;

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

		if (PlayerPrefs.GetInt("Tkhm1_Gm2_PlayingQuestionFinished")==2)
		{
		Img_Egg_Fake_ForGround.enabled = false;

		//hazf original az safhe
		GObject_Egg_Original.SetActive (false);


		//mohtaviat fake birun berizad
		Fake_wrongAnswerAnim[0].SetBool ("WrongAnswerIn_Egg_Fake",true);

		//play the notice sound  for wrong answer synchronized with the animation
		audioSource.PlayOneShot (audioClipWrongAnswer);
		StartCoroutine (WaitForSynchronizeAudioAndAnimation ());

		/*javab nadad 
		 * if (audioSource.time > 8f) {}*/
		}
	}

	IEnumerator WaitForSynchronizeAudioAndAnimation()
	{
		yield return new WaitForSeconds (8f);
		Img_Standard_Logo.enabled = true;
		//play animation Standard Logo
		Fake_wrongAnswerAnim[1].SetBool ("WrongAnswerStandard_Logo",true);
		Img_FDA_Logo.enabled = true;
		Fake_wrongAnswerAnim[2].SetBool ("WrongAnswerFDA_Logo",true);
		Img_Candy_Fake_Shaking.enabled = true;
		Fake_wrongAnswerAnim[3].SetBool ("WrongAnswerCandy",true);
	}


	//wait until the end of an animation -- may be useful
	IEnumerator WaitForFinishingAnimationIn_Egg_Fake()
	{
		RuntimeAnimatorController ac = Fake_wrongAnswerAnim[0].runtimeAnimatorController;

		yield return new WaitForSeconds (ac.animationClips.Length);
		//StartCoroutine (PlayAudioClipQuestionAndAnim_Standard_Logo ());
	}
		
}
