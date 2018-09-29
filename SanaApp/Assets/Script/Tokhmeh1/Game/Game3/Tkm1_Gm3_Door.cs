using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tkm1_Gm3_Door : MonoBehaviour {

	// Use this for initialization
	public AudioSource audioSource;
	public AudioClip audioClipDoor;
	public 	Animator DoorOpenAnim;

	void Start () {
		 DoorOpenAnim = GetComponent <Animator> ();
		
	}
	public void OnClickDoor()
	{
		DoorOpenAnim.SetBool ("Door", true);
	}

}
