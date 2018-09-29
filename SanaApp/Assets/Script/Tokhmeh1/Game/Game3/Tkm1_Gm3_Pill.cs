using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tkm1_Gm3_Pill : MonoBehaviour {
	public 	Animator PillAnim;

	void Start () {
		PillAnim = GetComponent <Animator> ();

	}


	// Update is called once per frame
	void Update () {

	}

	public void OnClickPill()
	{
		//BigPhone.SetActive (true);
		PillAnim.SetBool ("Pill", true);
	}
}
