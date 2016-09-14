using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainCameraController : MonoBehaviour {

	private iTween.EaseType easyType;

	public GameObject cameraStativ;
	public GameObject cameraIntro;

	private float StartDuration;

	public GameObject camera3D01;
	public GameObject camera3D02;
	public GameObject camera3D03;

	public GameObject cameraPosNeutral; 
	public GameObject cameraPos01; 
	public GameObject cameraPos02; 
	public GameObject cameraPos03; 
	public GameObject cameraPos04; 
	public GameObject cameraPosIntro; 
	public GameObject cameraPosIntroStart; 

	public Image BTN_neutral; 
	public Image BTN_strategie; 
	public Image BTN_baufinanz; 
	public Image BTN_digitalisierung; 
	public Image BTN_vertrieb;

	public Color standardColor; 
	public Color hightlightedColor;

	private float zoomLevelStart;
	private float zoomLevelEnd;

	public Text durationTXT;

	private int currentPosition; 

	private float duration;

	// Use this for initialization
	void Start () {

		easyType = iTween.EaseType.easeInOutExpo;
	
		zoomLevelStart = 0.2F;
		zoomLevelEnd = 8F;
		StartDuration = 5F;

		camera3D01.SetActive (false);
		camera3D02.SetActive (false);
		camera3D03.SetActive (false);
		cameraIntro.SetActive (true);

		saveDuration ();
		moveToNeutral ();
		currentPosition = 0;

		//set cam to start position
		iTween.MoveTo (cameraIntro, iTween.Hash ("position", cameraPosIntroStart.transform.position, "easetype",easyType, "time", 1F));

		//set cam zoom level
		cameraIntro.GetComponent<Camera>().orthographicSize = zoomLevelStart;

		BTN_neutral.color = standardColor;
		BTN_strategie.color = standardColor; 
		BTN_baufinanz.color = standardColor; 
		BTN_digitalisierung.color = standardColor; 
		BTN_vertrieb.color = standardColor;

	}

	void Update () {
	
	}
		

	void tweenOnUpdateCallBack( float newValue )
	{
		cameraIntro.GetComponent<Camera>().orthographicSize = newValue;
	}


	public void StartGame() {
		StartCoroutine (waitWithStartGame ());
	}

	private IEnumerator waitWithStartGame() {
		yield return new WaitForSeconds (0F);

		iTween.MoveTo (cameraIntro, iTween.Hash ("position", cameraPosIntro.transform.position, "easetype", easyType, "time", StartDuration));

		iTween.ValueTo( cameraIntro, iTween.Hash(
			"from", zoomLevelStart,
			"to", 8f,
			"time", StartDuration,
			"onupdatetarget", gameObject,
			"onupdate", "tweenOnUpdateCallBack",
			"easetype", easyType)	
		);

		StartCoroutine (switchActiveCams ());
	}



	public void resetAll() {
		camera3D01.SetActive (false);
		camera3D02.SetActive (false);
		camera3D03.SetActive (false);
		cameraIntro.SetActive (true);

		//set cam to start position
		iTween.MoveTo (cameraIntro, iTween.Hash ("position", cameraPosIntroStart.transform.position, "easetype", easyType, "time", 1F));

		moveToNeutral (1f);

		BTN_neutral.color = standardColor;
		BTN_strategie.color = standardColor; 
		BTN_baufinanz.color = standardColor; 
		BTN_digitalisierung.color = standardColor; 
		BTN_vertrieb.color = standardColor;

		StartCoroutine (resetAll02 ());

	}

	IEnumerator resetAll02() {
		yield return new WaitForSeconds (1f);

		//set cam zoom level
		iTween.ValueTo( cameraIntro, iTween.Hash(
			"from", zoomLevelEnd,
			"to", 0.2f,
			"time", 1f,
			"onupdatetarget", gameObject,
			"onupdate", "tweenOnUpdateCallBack",
			"easetype", easyType)	
		);
	}


	public void EndGame() {

		camera3D01.SetActive (false);
		camera3D02.SetActive (false);
		camera3D03.SetActive (false);
		cameraIntro.SetActive (true);

		iTween.MoveTo (cameraIntro, iTween.Hash ("position", cameraPosIntroStart.transform.position, "easetype", easyType, "time", StartDuration));

		iTween.ValueTo( cameraIntro, iTween.Hash(
			"from", zoomLevelEnd,
			"to", 0.2f,
			"time", StartDuration,
			"onupdatetarget", gameObject,
			"onupdate", "tweenOnUpdateCallBack",
			"easetype", easyType)	
		);

	}
		

	private IEnumerator switchActiveCams() {
		yield return new WaitForSeconds (StartDuration);
		camera3D01.SetActive (true);
		camera3D02.SetActive (true);
		camera3D03.SetActive (true);
		cameraIntro.SetActive (false);

		BTN_neutral.color = hightlightedColor;
		BTN_strategie.color = standardColor; 
		BTN_baufinanz.color = standardColor; 
		BTN_digitalisierung.color = standardColor; 
		BTN_vertrieb.color = standardColor;

	}



	public void moveToNeutral() {
		
		BTN_neutral.color = hightlightedColor;
		BTN_strategie.color = standardColor; 
		BTN_baufinanz.color = standardColor; 
		BTN_digitalisierung.color = standardColor; 
		BTN_vertrieb.color = standardColor;

		saveDuration ();
		iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPosNeutral.transform.position, "easetype", easyType, "time", duration));
		iTween.RotateTo (cameraStativ, iTween.Hash ("y", 0F, "easetype", easyType, "time", duration));
		currentPosition = 0;
	}

	public void moveToNeutral(float durationNew) {
		
		BTN_neutral.color = hightlightedColor;
		BTN_strategie.color = standardColor; 
		BTN_baufinanz.color = standardColor; 
		BTN_digitalisierung.color = standardColor; 
		BTN_vertrieb.color = standardColor;

		saveDuration ();
		iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPosNeutral.transform.position, "easetype",easyType, "time", durationNew));
		iTween.RotateTo (cameraStativ, iTween.Hash ("y", 0F, "easetype", easyType, "time", durationNew));
		currentPosition = 0;
	}

	public void moveTo01() {
		
		BTN_neutral.color = standardColor;
		BTN_strategie.color = hightlightedColor; 
		BTN_baufinanz.color = standardColor; 
		BTN_digitalisierung.color = standardColor; 
		BTN_vertrieb.color = standardColor;

		saveDuration ();
		iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos01.transform.position, "easetype", easyType, "time", duration));
		iTween.RotateTo (cameraStativ, iTween.Hash ("y", -90F, "easetype", easyType, "time", duration));
		currentPosition = 1;
	}

	public void moveTo02() {
		
		BTN_neutral.color = standardColor;
		BTN_strategie.color = standardColor; 
		BTN_baufinanz.color = hightlightedColor; 
		BTN_digitalisierung.color = standardColor; 
		BTN_vertrieb.color = standardColor;

		saveDuration ();
		iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos02.transform.position, "easetype", easyType, "time", duration));
		iTween.RotateTo (cameraStativ, iTween.Hash ("y", 0F, "easetype", easyType, "time", duration));
		currentPosition = 2;
	}

	public void moveTo03() {

		BTN_neutral.color = standardColor;
		BTN_strategie.color = standardColor; 
		BTN_baufinanz.color = standardColor; 
		BTN_digitalisierung.color = hightlightedColor; 
		BTN_vertrieb.color = standardColor;

		saveDuration ();
		iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos03.transform.position, "easetype", easyType, "time", duration));
		iTween.RotateTo (cameraStativ, iTween.Hash ("y", 0F, "easetype", easyType, "time", duration));
		currentPosition = 3;
	}

	public void moveTo04() {

		BTN_neutral.color = standardColor;
		BTN_strategie.color = standardColor; 
		BTN_baufinanz.color = standardColor; 
		BTN_digitalisierung.color = standardColor; 
		BTN_vertrieb.color = hightlightedColor;

		saveDuration ();
		iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos04.transform.position, "easetype", easyType, "time", duration));
		iTween.RotateTo (cameraStativ, iTween.Hash ("y", 90F, "easetype", easyType, "time", duration));
		currentPosition = 4;
	}

	private void saveDuration() {
		duration = float.Parse (durationTXT.text);
	}


	public void focusPosition() {
		/*
		if (currentPosition == 0) {
			iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPosNeutral.transform.position, "easetype", easyType, "time", 10F));
		} else if (currentPosition == 1) {
			iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos01.transform.position, "easetype", easyType, "time", 10F));
		} else if (currentPosition == 2) {
			iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos02.transform.position, "easetype", easyType, "time", 10F));
		} else if (currentPosition == 3) { 
			iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos03.transform.position, "easetype", easyType, "time", 10F));
		} else { 
			iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos04.transform.position, "easetype", easyType, "time", 10F));
		}
*/
	}


}
