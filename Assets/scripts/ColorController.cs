﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorController : MonoBehaviour
{



	public GameObject purplePlane;
	// #0
	public GameObject bluePlane;
	// #1
	public GameObject greenPlane;
	// #2
	public GameObject redPlane;
	// #3

	private Vector3 startPosResult;

	public GameObject blackLeft;
	public GameObject blackRight;

	public float positionBlackLeft;
	public float positionBlackRight;

	public Text countdownDuration;

	GameObject _mainControllerGO;
	MainGameController _mainController;

	public Image BTN_openSwing; 
	public Image BTN_closeSwing; 

	public Color standardColor; 
	public Color highlightedColor;

	//result TXT
	public Text resultTXT;
	public Text resultTXTfloat;



	// Use this for initialization
	void Start ()
	{
		BTN_closeSwing.color = highlightedColor;


		positionBlackLeft = blackLeft.GetComponent<RectTransform> ().anchoredPosition.x;
		positionBlackRight = blackRight.GetComponent<RectTransform> ().anchoredPosition.x;


		startPosResult = resultTXT.GetComponent<RectTransform> ().anchoredPosition;

		//_mainGameController
		_mainControllerGO = GameObject.Find ("_MainGameController");
		_mainController = _mainControllerGO.GetComponent<MainGameController> ();

		//start with two planes
		//greenPlane.transform.SetParent(_foreground.transform);
		//purplePlane.transform.SetParent (_background.transform);

		//fadeOut all colorPlanes
		fadeInOutImage (0F, greenPlane, 0F);
		fadeInOutImage (0F, purplePlane, 0F);
		fadeInOutImage (0F, bluePlane, 0F);
		fadeInOutImage (0F, redPlane, 0F);
		fadeInOutTXT (0F, resultTXT, 0F);
		TranslateBlackIn (0F);

		startSwing ();

	}

	void Update ()
	{
	}


	public void startSwing ()
	{
		BTN_openSwing.color = highlightedColor; 
		BTN_closeSwing.color = standardColor;
		TranslateBlackOut (3F);
	}

	public void closeSwing ()
	{
		BTN_openSwing.color = standardColor; 
		BTN_closeSwing.color = highlightedColor;
		TranslateBlackIn (3F);
	}


	public void openCloseSwing() {
		if (BTN_openSwing.color == standardColor) {
			BTN_openSwing.color = highlightedColor; 
			BTN_closeSwing.color = standardColor;
			TranslateBlackOut (2F);
		} else {
			BTN_openSwing.color = standardColor; 
			BTN_closeSwing.color = highlightedColor;
			TranslateBlackIn (2F);
		}

	}




	public void removeResults ()
	{
		float translateX = -550F;
		float duration = 3F;

		//if (_mainController.currentStatusSequence == 0) {
			TranslateBlackOut (2F);
		//}

		if (_mainController.currentResultColor == 0) {
			iTween.MoveTo (purplePlane, iTween.Hash ("x", translateX, "easetype", iTween.EaseType.easeInOutSine, "time", duration));
			StartCoroutine (repositionColorPlanes (purplePlane, duration));
		} else if (_mainController.currentResultColor == 1) {
			iTween.MoveTo (bluePlane, iTween.Hash ("x", translateX, "easetype", iTween.EaseType.easeInOutSine, "time", duration));
			StartCoroutine (repositionColorPlanes (bluePlane, duration));
		} else if (_mainController.currentResultColor == 2) {
			iTween.MoveTo (greenPlane, iTween.Hash ("x", translateX, "easetype", iTween.EaseType.easeInOutSine, "time", duration));
			StartCoroutine (repositionColorPlanes (greenPlane, duration));
		} else {
			iTween.MoveTo (redPlane, iTween.Hash ("x", translateX, "easetype", iTween.EaseType.easeInOutSine, "time", duration));
			StartCoroutine (repositionColorPlanes (redPlane, duration));
		}
	}


	IEnumerator repositionColorPlanes (GameObject plane, float wait)
	{
		iTween.MoveTo (resultTXT.gameObject, iTween.Hash ("x", -400F, "easetype", iTween.EaseType.easeInOutSine, "time", wait));
		yield return new WaitForSeconds (wait); 
		//plane invisible
		fadeInOutImage (0F, plane, 0F);
		iTween.MoveTo (plane, iTween.Hash ("x", 0, "easetype", iTween.EaseType.linear, "time", 0.01F));
		//result invisible
		iTween.MoveTo (resultTXT.gameObject, iTween.Hash ("x", startPosResult.x, "time", 0.01F));
		fadeInOutTXT (0F, resultTXT, 0F);
	}




	IEnumerator refreshDuration ()
	{
		yield return new WaitForSeconds (1F);
		countdownDuration.text = "20";
	}


	public void TranslateBlackIn ()
	{
		iTween.MoveTo (blackLeft, iTween.Hash ("x", 264F, "easetype", iTween.EaseType.linear, "time", float.Parse (countdownDuration.text)));
		iTween.MoveTo (blackRight, iTween.Hash ("x", 264F, "easetype", iTween.EaseType.linear, "time", float.Parse (countdownDuration.text)));
	}

	public void TranslateBlackIn (float time)
	{
		iTween.MoveTo (blackLeft, iTween.Hash ("x", 264F, "easetype", iTween.EaseType.linear, "time", time));
		iTween.MoveTo (blackRight, iTween.Hash ("x", 264F, "easetype", iTween.EaseType.linear, "time", time));
	}

	void TranslateBlackOut (float time)
	{
		iTween.MoveTo (blackLeft, iTween.Hash ("x", positionBlackLeft, "easetype", iTween.EaseType.easeInOutSine, "time", time));
		iTween.MoveTo (blackRight, iTween.Hash ("x", positionBlackRight, "easetype", iTween.EaseType.easeInOutSine, "time", time));
	}


	public void showResults ()
	{
		StartCoroutine (showColorResult ());
	}

	IEnumerator showColorResult ()
	{
		yield return new WaitForSeconds (0.5F);

		//get winner TXT

		if (_mainController.currentResultFloat != 0F) {

			if (_mainController.currentStatusSequence == 3) {

				fadeInOutTXT (1F, resultTXT, 0F);

				//getWinnerColor
				if (_mainController.currentResultColor == 0) {
					fadeInOutImage (1F, purplePlane, 0F);
				} else if (_mainController.currentResultColor == 1) {
					fadeInOutImage (1F, bluePlane, 0F);
				} else if (_mainController.currentResultColor == 2) {
					fadeInOutImage (1F, greenPlane, 0F);
				} else {
					fadeInOutImage (1F, redPlane, 0F);
				}

				//only take winner string
				//resultTXT.text = _mainController.currentResultString + " " + _mainController.currentResultFloat + " %";
				string tmp = _mainController.currentResultString; 

				string tmpFloat = _mainController.currentResultFloat.ToString ("0");

				tmp = tmp.Substring (0, 1);

				tmp = tmp + ": " + tmpFloat + " %";

				resultTXT.text = tmp;

				TranslateBlackOut (2F);

			} 
		}

	}

	void fadeInOutImage (float InOut, GameObject img, float time)
	{
		img.GetComponent<Image> ().CrossFadeAlpha (InOut, time, false);
	}

	void fadeInOutTXT (float InOut, Text txt, float time)
	{
		txt.CrossFadeAlpha (InOut, time, false);
	}




}
