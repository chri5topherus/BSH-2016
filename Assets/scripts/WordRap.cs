using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class WordRap : MonoBehaviour {

	public GameObject _blackBG;
	public float waitingTime;

	public GameObject _secondInserts;

	private List<Text> textElements;
	private Text[] tmpTXTArray;

	private List<Text> textElements02;
	private Text[] tmpTXTArray02;

	public Image BTN_rap01; 
	public Image BTN_rap02; 
	public Image BTN_off; 

	public Color standardColor; 
	public Color hightlightedColor; 

	private bool running;
	private bool running02;

	private float leftBGposition;

	// Use this for initialization
	void Start () {
	
		leftBGposition = -550F;

		running = false;
		running02 = false;

		waitingTime = 2F;

		textElements = new List<Text>();
		textElements02 = new List<Text>();

		//move bg out 
		iTween.MoveTo (_blackBG, iTween.Hash ("x", leftBGposition, "easetype", iTween.EaseType.easeInOutExpo, "time", 0.1F));


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


		//second round
		//get all children TXT elements
		tmpTXTArray02 = _secondInserts.GetComponentsInChildren<Text> ();
		for (int i = 1; i < tmpTXTArray02.Length; i++) {
			textElements02.Add(tmpTXTArray02[i]);
		}

		//fade all out
		for (int i = 0; i < textElements02.Count; i++) {
			textElements02 [i].CrossFadeAlpha (0F, 0F, false);
		}

		BTN_off.color = hightlightedColor; 
			
	} // end start





	// Update is called once per frame
	void Update () {
	
	}






	public void StartRap() {

		BTN_rap01.color = hightlightedColor; 
		BTN_rap02.color = standardColor; 
		BTN_off.color = standardColor; 

		//move BG in
		running = true;
		running02 = false;
		iTween.MoveTo (_blackBG, iTween.Hash ("x", 0F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F));
		StartCoroutine(StartFadingTXT(0, waitingTime));
	}

	public void StartRapPart2() {
		
		BTN_rap01.color = standardColor; 
		BTN_rap02.color = hightlightedColor; 
		BTN_off.color = standardColor; 

		running = false;
		running02 = true;
		StartCoroutine(StartFadingTXT02(0, waitingTime));
	}


		
	public void StopRap() {
		
		BTN_rap01.color = standardColor; 
		BTN_rap02.color = standardColor; 
		BTN_off.color = hightlightedColor; 

		running = false;
		running02 = false;
		//move BG out
		iTween.MoveTo (_blackBG, iTween.Hash ("x", leftBGposition, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay" , 2F));
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


	IEnumerator StartFadingTXT02(int currentTXT, float wait) {
		yield return new WaitForSeconds (wait);
		if (running02) {
			textElements02 [currentTXT].CrossFadeAlpha (1F, 1F, false);
			StartCoroutine (StopFadingTXT02 (currentTXT, waitingTime));
			if (currentTXT == textElements02.Count - 1)
				currentTXT = 0;
			else
				currentTXT = currentTXT + 1;
			StartCoroutine (StartFadingTXT02 (currentTXT, waitingTime));
		}
	}

	IEnumerator StopFadingTXT02(int currentTXT, float wait) {
		yield return new WaitForSeconds(wait);
		textElements02 [currentTXT].CrossFadeAlpha (0F, 1F, false);
	}


}
