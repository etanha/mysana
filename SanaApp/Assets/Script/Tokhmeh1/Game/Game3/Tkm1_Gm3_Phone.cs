using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tkm1_Gm3_Phone : MonoBehaviour {

	public 	Animator PhoneAnim;

	void Start () {
		PhoneAnim = GetComponent <Animator> ();
	}

	
	public void OnClickSmallPhone()
	{
		//BigPhone.SetActive (true);
		PhoneAnim.SetBool ("Phone", true);
	}
}
