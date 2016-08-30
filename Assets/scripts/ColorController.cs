using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorController : MonoBehaviour {



	public GameObject purplePlane; 		// #0
	public GameObject bluePlane;		// #1
	public GameObject greenPlane; 		// #2
	public GameObject redPlane;			// #3


	public GameObject blackLeft;
	public GameObject blackRight;

	public float positionBlackLeft; 
	public float positionBlackRight;

	public Text countdownDuration;

	GameObject _mainControllerGO;
	MainGameController _mainController;


	//result TXT
	public Text resultTXT;
	public Text resultTXTfloat;



	// Use this for initialization
	void Start () {

		positionBlackLeft = blackLeft.GetComponent<RectTransform> ().anchoredPosition.x;
		positionBlackRight = blackRight.GetComponent<RectTransform> ().anchoredPosition.x;


		//_mainGameController
		_mainControllerGO = GameObject.Find("_MainGameController");
		_mainController = _mainControllerGO.GetComponent<MainGameController>();


		//start with two planes
		//greenPlane.transform.SetParent(_foreground.transform);
		//purplePlane.transform.SetParent (_background.transform);

		//fadeOut all colorPlanes
		fadeInOutImage(0F, greenPlane, 0F);
		fadeInOutImage(0F, purplePlane, 0F);
		fadeInOutImage(0F, bluePlane, 0F);
		fadeInOutImage(0F, redPlane, 0F);
		fadeInOutTXT (0F, resultTXT, 0F);


	}

	// Update is called once per frame
	void Update () {




	}




	IEnumerator refreshDuration() {
		yield return new WaitForSeconds (1F);
		countdownDuration.text = "20";
	}









	public void TranslateBlackIn() {
		iTween.MoveTo (blackLeft, iTween.Hash ("x", 300F, "easetype", iTween.EaseType.linear, "time", float.Parse(countdownDuration.text)));
		iTween.MoveTo (blackRight, iTween.Hash ("x", 300F, "easetype", iTween.EaseType.linear, "time", float.Parse(countdownDuration.text)));
	}

	void TranslateBlackOut() {
		iTween.MoveTo (blackLeft, iTween.Hash ("x", positionBlackLeft, "easetype", iTween.EaseType.easeInOutSine, "time", 2F));
		iTween.MoveTo (blackRight, iTween.Hash ("x", positionBlackRight, "easetype", iTween.EaseType.easeInOutSine, "time", 2F));
	}


	public void showResults() {
		StartCoroutine (showColorResult ());
	}

	IEnumerator showColorResult() {
		yield return new WaitForSeconds (0.5F);


		//get winner TXT
		//Debug.Log(_mainController.currentResultFloat + "newwinner");

		if (_mainController.currentResultFloat != 0F) {
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

			resultTXT.text = _mainController.currentResultString + " " + _mainController.currentResultFloat + " %";
			;

			TranslateBlackOut ();
		}

	}

	void fadeInOutImage(float InOut, GameObject img, float time) {
		img.GetComponent<Image> ().CrossFadeAlpha (InOut, time, false);
	}

	void fadeInOutTXT(float InOut, Text txt, float time) {
		txt.CrossFadeAlpha (InOut, time, false);
	}




}
