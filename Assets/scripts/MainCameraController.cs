using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainCameraController : MonoBehaviour {

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

	private float zoomLevel;

	public Text durationTXT;

	private int currentPosition; 

	private float duration;

	// Use this for initialization
	void Start () {
	
		zoomLevel = 0.2F;
		StartDuration = 10F;

		camera3D01.SetActive (false);
		camera3D02.SetActive (false);
		camera3D03.SetActive (false);
		cameraIntro.SetActive (true);

		saveDuration ();
		moveToNeutral ();
		currentPosition = 0;

		//set cam to start position
		iTween.MoveTo (cameraIntro, iTween.Hash ("position", cameraPosIntroStart.transform.position, "easetype", iTween.EaseType.easeInOutQuart, "time", 1F));

		//set cam zoom level
		cameraIntro.GetComponent<Camera>().orthographicSize = zoomLevel;

	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void tweenOnUpdateCallBack( float newValue )
	{
		zoomLevel = newValue;
		cameraIntro.GetComponent<Camera>().orthographicSize = zoomLevel;
	}


	public void StartGame() {
		iTween.MoveTo (cameraIntro, iTween.Hash ("position", cameraPosIntro.transform.position, "easetype", iTween.EaseType.easeInOutQuart, "time", StartDuration));
		iTween.ValueTo( cameraIntro, iTween.Hash(
			"from", zoomLevel,
			"to", 8f,
			"time", StartDuration,
			"onupdatetarget", gameObject,
			"onupdate", "tweenOnUpdateCallBack",
			"easetype", iTween.EaseType.easeInOutQuart)	
		);

		StartCoroutine (switchActiveCams ());

	}

	private IEnumerator switchActiveCams() {
		yield return new WaitForSeconds (StartDuration);
		camera3D01.SetActive (true);
		camera3D02.SetActive (true);
		camera3D03.SetActive (true);
		cameraIntro.SetActive (false);
	}



	public void moveToNeutral() {
		saveDuration ();
		iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPosNeutral.transform.position, "easetype", iTween.EaseType.easeInOutQuart, "time", duration));
		iTween.RotateTo (cameraStativ, iTween.Hash ("y", 0F, "easetype", iTween.EaseType.easeInOutQuart, "time", duration));
		currentPosition = 0;
	}

	public void moveTo01() {
		saveDuration ();
		iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos01.transform.position, "easetype", iTween.EaseType.easeInOutQuart, "time", duration));
		iTween.RotateTo (cameraStativ, iTween.Hash ("y", -90F, "easetype", iTween.EaseType.easeInOutQuart, "time", duration));
		currentPosition = 1;
	}

	public void moveTo02() {
		saveDuration ();
		iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos02.transform.position, "easetype", iTween.EaseType.easeInOutQuart, "time", duration));
		iTween.RotateTo (cameraStativ, iTween.Hash ("y", 0F, "easetype", iTween.EaseType.easeInOutQuart, "time", duration));
		currentPosition = 2;
	}

	public void moveTo03() {
		saveDuration ();
		iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos03.transform.position, "easetype", iTween.EaseType.easeInOutQuart, "time", duration));
		iTween.RotateTo (cameraStativ, iTween.Hash ("y", 0F, "easetype", iTween.EaseType.easeInOutQuart, "time", duration));
		currentPosition = 3;
	}

	public void moveTo04() {
		saveDuration ();
		iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos04.transform.position, "easetype", iTween.EaseType.easeInOutQuart, "time", duration));
		iTween.RotateTo (cameraStativ, iTween.Hash ("y", 90F, "easetype", iTween.EaseType.easeInOutQuart, "time", duration));
		currentPosition = 4;
	}

	private void saveDuration() {
		duration = float.Parse (durationTXT.text);
	}


	public void focusPosition() {
		if (currentPosition == 0) {
			iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPosNeutral.transform.position, "easetype", iTween.EaseType.easeInOutQuart, "time", 15F));
		} else if (currentPosition == 1) {
			iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos01.transform.position, "easetype", iTween.EaseType.easeInOutQuart, "time", 15F));
		} else if (currentPosition == 2) {
			iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos02.transform.position, "easetype", iTween.EaseType.easeInOutQuart, "time", 15F));
		} else if (currentPosition == 3) { 
			iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos03.transform.position, "easetype", iTween.EaseType.easeInOutQuart, "time", 15F));
		} else { 
			iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos04.transform.position, "easetype", iTween.EaseType.easeInOutQuart, "time", 15F));
		}
	}


}
