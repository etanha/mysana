using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tkm1_Gm3_Water : MonoBehaviour {

	public 	Animator PitcherAnim;
	//public Image water;

	void Start () {
		PitcherAnim = GetComponent <Animator> ();
		//water.enabled =true;
	}


	public void OnClickPitcher()
	{
		//water.enabled =true;
		PitcherAnim.SetBool ("Water", true);
	}
}
