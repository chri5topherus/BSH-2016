using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class WordRap : MonoBehaviour {

	public GameObject _blackBG;
	public float waitingTime;

	private List<Text> textElements;
	private Text[] tmpTXTArray;
	private bool running;

	// Use this for initialization
	void Start () {
	

		running = false;
		waitingTime = 2F;

		textElements = new List<Text>();

		//move bg out 
		iTween.MoveTo (_blackBG, iTween.Hash ("x", -570F, "easetype", iTween.EaseType.easeInOutExpo, "time", 0.1F));

		//get all children TXT elements
		tmpTXTArray = gameObject.GetComponentsInChildren<Text> ();
		for (int i = 1; i < tmpTXTArray.Length; i++) {
			textElements.Add(tmpTXTArray[i]);
		}


		//fade all out
		for (int i = 0; i < textElements.Count; i++) {
			//Debug.Log (textElements [i].text);
			textElements [i].CrossFadeAlpha (0F, 0F, false);
		}


		//StartRap ();
		//Debug.Log (textElements.Count);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartRap() {
		//move BG in
		running = true;
		iTween.MoveTo (_blackBG, iTween.Hash ("x", 0F, "easetype", iTween.EaseType.easeInOutExpo, "time", 1F));
		StartCoroutine(StartFadingTXT(0, waitingTime));
	}
		
	public void StopRap() {
		//move BG out
		iTween.MoveTo (_blackBG, iTween.Hash ("x", -570F, "easetype", iTween.EaseType.easeInOutExpo, "time", 1F, "delay" , 3F));
		running = false;
	}
		
	IEnumerator StartFadingTXT(int currentTXT, float wait) {
		yield return new WaitForSeconds (wait);
		if (running) {
			textElements [currentTXT].CrossFadeAlpha (1F, 1F, false);
			StartCoroutine (StopFadingTXT (currentTXT, waitingTime));
			if (currentTXT == textElements.Count - 1)
				currentTXT = 0;
			else
				currentTXT = currentTXT + 1;
			StartCoroutine (StartFadingTXT (currentTXT, waitingTime));
		}
	}

	IEnumerator StopFadingTXT(int currentTXT, float wait) {
		yield return new WaitForSeconds(wait);
		textElements [currentTXT].CrossFadeAlpha (0F, 1F, false);

	}


}
