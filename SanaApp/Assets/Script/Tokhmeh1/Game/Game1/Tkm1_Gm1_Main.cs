using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//using System.Runtime.Serialization.Formatters.Binary;

public class Tkm1_Gm1_Main : MonoBehaviour {

	int count=0;
	Button first_Btn_Layer;
	int first_ImageNumber;
	public List <Sprite> ImagesList = new List<Sprite>();

	void Start () {
		
		//random number without repeat
		int i = 1;
		while (ImagesList.Count > 0) {
			
			int index = UnityEngine.Random.Range (0, ImagesList.Count - 1);
			Button Btn_Image = GameObject.Find ("Btn_" + i).GetComponent <Button> ();
			Btn_Image.image.sprite = ImagesList [index];
			i++;
			ImagesList.RemoveAt (index);
		}

		//ijade laye roye aksha
		StartCoroutine (PushLayerImage());
	}

	//ijade laye roye aksha
	IEnumerator PushLayerImage(){
		yield return new WaitForSeconds (5f);
		for (int i = 1; i < 15; i++) {
			Button Btn_Layer = GameObject.Find ("Btn_Layer_" + i).GetComponent <Button> ();
			Btn_Layer.image.enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Show_Image(int ImageNumber){
		count ++;

		//invisible layer button
		Button Btn_Layer = GameObject.Find ("Btn_Layer_" + ImageNumber).GetComponent <Button> ();
		Btn_Layer.image.enabled = false;

		if (count == 1) {
			first_ImageNumber = ImageNumber;
			first_Btn_Layer = Btn_Layer;
		}
		else if (count == 2) {
			count = 0;
			//check the correct 2 Images
			if (CorrectImages (ImageNumber)) {
				Debug.Log ("correct");
			} else {
				//ijade laye roye 2 aks 
				StartCoroutine (PushLayer2Image(Btn_Layer));
			}
		} 
	}

	//check the correct 2 Images
	public bool CorrectImages (int ImageNumber){

		Button Btn_Image = GameObject.Find ("Btn_" + ImageNumber).GetComponent <Button> ();
		Button first_Btn_Image = GameObject.Find ("Btn_" + first_ImageNumber).GetComponent <Button> ();

		String P =Btn_Image.image.sprite.ToString();
		Debug.Log (P);

		switch (P) 
		{
		case "Tkhm1_Gm1_110":
			Debug.Log (first_Btn_Image.image.sprite.ToString());
			if (string.Equals(first_Btn_Image.image.sprite.ToString(),"Tkhm1_Gm1_Police"))
				return true;
			else
				return false;
			break;

		case "Tkhm1_Gm1_115":
			if (first_Btn_Image.image.sprite.ToString() == "Tkhm1_Gm1_Orjans")
				return true;
			else
				return false;
			break;
		case "Tkhm1_Gm1_122":
			if (first_Btn_Image.image.sprite.ToString() == "Tkhm1_Gm1_Ab")
				return true;
			else
				return false;
			break;
		case "Tkhm1_Gm1_194":
			if (first_Btn_Image.image.sprite.ToString() == "Tkhm1_Gm1_Gaz")
				return true;
			else
				return false;
			break;
		case "Tkhm1_Gm1_125":
			if (first_Btn_Image.image.sprite.ToString() == "Tkhm1_Gm1_atashNeshani")
				return true;
			else
				return false;
			break;
		case "Tkhm1_Gm1_121":
			if (first_Btn_Image.image.sprite.ToString() == "Tkhm1_Gm1_Bargh")
				return true;
			else
				return false;
			break;
		case "Tkhm1_Gm1_123":
			if (first_Btn_Image.image.sprite.ToString() == "Tkhm1_Gm1_OrjansEjtemayi")
				return true;
			else
				return false;
			break;
		case "Tkhm1_Gm1_Police":
			if (first_Btn_Image.image.sprite.ToString() == "Tkhm1_Gm1_110")
				return true;
			else
				return false;
			break;

		case "Tkhm1_Gm1_Orjans":
			if (first_Btn_Image.image.sprite.ToString() == "Tkhm1_Gm1_115")
				return true;
			else
				return false;
			break;
		case "Tkhm1_Gm1_Ab":
			if (first_Btn_Image.image.sprite.ToString() == "Tkhm1_Gm1_122")
				return true;
			else
				return false;
			break;
		case "Tkhm1_Gm1_Gaz":
			if (first_Btn_Image.image.sprite.ToString() == "Tkhm1_Gm1_194")
				return true;
			else
				return false;
			break;
		case "Tkhm1_Gm1_atashNeshani":
			if (first_Btn_Image.image.sprite.ToString() == "Tkhm1_Gm1_125")
				return true;
			else
				return false;
			break;
		case "Tkhm1_Gm1_Bargh":
			if (first_Btn_Image.image.sprite.ToString() == "Tkhm1_Gm1_121")
				return true;
			else
				return false;
			break;
		case "Tkhm1_Gm1_OrjansEjtemayi":
			if (first_Btn_Image.image.sprite.ToString() == "Tkhm1_Gm1_123")
				return true;
			else
				return false;
			break;
		default:
			return false;
		}
		//return false;
	}

	//ijade laye roye 2 aks
	IEnumerator PushLayer2Image(Button Btn_Layer){
		yield return new WaitForSeconds (1f);
		Btn_Layer.image.enabled = true;
		first_Btn_Layer.image.enabled = true;
	}
}
