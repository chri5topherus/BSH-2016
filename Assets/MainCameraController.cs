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

	private float duration;

	// Use this for initialization
	void Start () {
	
		saveDuration ();
		moveToNeutral ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void moveToNeutral() {
		saveDuration ();
		iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPosNeutral.transform.position, "easetype", iTween.EaseType.easeInOutExpo, "time", duration));
		iTween.RotateTo (cameraStativ, iTween.Hash ("y", 0F, "easetype", iTween.EaseType.easeInOutExpo, "time", duration));
	}

	public void moveTo01() {
		saveDuration ();
		iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos01.transform.position, "easetype", iTween.EaseType.easeInOutExpo, "time", duration));
		iTween.RotateTo (cameraStativ, iTween.Hash ("y", -90F, "easetype", iTween.EaseType.easeInOutExpo, "time", duration));
	}

	public void moveTo02() {
		saveDuration ();
		iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos02.transform.position, "easetype", iTween.EaseType.easeInOutExpo, "time", duration));
		iTween.RotateTo (cameraStativ, iTween.Hash ("y", 0F, "easetype", iTween.EaseType.easeInOutExpo, "time", duration));
	}

	public void moveTo03() {
		saveDuration ();
		iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos03.transform.position, "easetype", iTween.EaseType.easeInOutExpo, "time", duration));
		iTween.RotateTo (cameraStativ, iTween.Hash ("y", 0F, "easetype", iTween.EaseType.easeInOutExpo, "time", duration));
	}

	public void moveTo04() {
		saveDuration ();
		iTween.MoveTo (cameraStativ, iTween.Hash ("position", cameraPos04.transform.position, "easetype", iTween.EaseType.easeInOutExpo, "time", duration));
		iTween.RotateTo (cameraStativ, iTween.Hash ("y", 90F, "easetype", iTween.EaseType.easeInOutExpo, "time", duration));
	}

	private void saveDuration() {
		duration = float.Parse (durationTXT.text);
	}



}
