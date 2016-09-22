using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class LaufbandAnimation : MonoBehaviour {


	private List<Text> textElements;
	private Text[] tmpTXTArray;
	private int currentTXT;

	void Start () {

		currentTXT = 0;

		textElements = new List<Text>();

		//get all children TXT elements
		tmpTXTArray = gameObject.GetComponentsInChildren<Text> ();
		for (int i = 1; i < tmpTXTArray.Length; i++) {
			textElements.Add(tmpTXTArray[i]);
		}
			
		//fade all out
		for (int i = 0; i < textElements.Count; i++) {
			textElements [i].CrossFadeAlpha (0F, 0F, false);
		}
	}

	void Update () {
	
	}

	public void ShowTXT(int i) {
		if (i != currentTXT) {
			StartCoroutine(showTXTdelayed(i));
			textElements [currentTXT].CrossFadeAlpha (0F, 0.5F, false);
			currentTXT = i;
		}
	}

	private IEnumerator showTXTdelayed(int i) {
		yield return new WaitForSeconds (0.5F); 
		textElements [i].CrossFadeAlpha (1F, 0.5F, false);
	}






}
