using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookSelect : MonoBehaviour {
     Animator anim;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SelectBook1()
    {
        anim.SetBool("isBook1Selected", true);
    }
    public void SelectBook2()
    {
        anim.SetBool("isBook2Selected", true);
    }

}
