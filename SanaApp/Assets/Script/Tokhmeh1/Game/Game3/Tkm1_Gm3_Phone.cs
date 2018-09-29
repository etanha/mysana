using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tkm1_Gm3_Phone : MonoBehaviour {

	public 	Animator PhoneAnim;

	void Start () {
		PhoneAnim = GameObject.Find("GameObject_Phone").GetComponent <Animator> ();
	}

	
	public void OnClickSmallPhone()
	{
		//BigPhone.SetActive (true);
		PhoneAnim.Play("3test_Phone_ZoomAnim");
		PhoneAnim.SetBool ("Phone", true);
	}
}
