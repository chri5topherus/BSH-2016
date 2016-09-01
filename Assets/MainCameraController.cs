using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainCameraController : MonoBehaviour {

	public GameObject cameraStativ;

	public GameObject cameraPosNeutral; 
	public GameObject cameraPos01; 
	public GameObject cameraPos02; 
	public GameObject cameraPos03; 
	public GameObject cameraPos04; 

	public Text durationTXT;

	private int currentPosition; 

	private float duration;

	// Use this for initialization
	void Start () {
	
		saveDuration ();
		moveToNeutral ();
		currentPosition = 0;

	}
	
	// Update is called once per frame
	void Update () {
	
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
