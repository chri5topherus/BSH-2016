using UnityEngine;
using System.Collections;

public class ColorController : MonoBehaviour {


	public GameObject greenPlane; 		// #0
	public GameObject purplePlane; 		// #1
	public GameObject bluePlane;		// #2
	public GameObject redPlane;			// #3

	public GameObject _foreground;
	public GameObject _background;
	public GameObject _tmp;

	private bool greenPlaneInside;
	private bool purplePlaneInside;
	private bool bluePlaneInside;
	private bool redPlaneInside;

	// Use this for initialization
	void Start () {
		greenPlaneInside = false;
		purplePlaneInside = false;
		bluePlaneInside = false;
		redPlaneInside = false;

		//start with two planes
		greenPlane.transform.SetParent(_foreground.transform);
		purplePlane.transform.SetParent (_background.transform);
	}

	// Update is called once per frame
	void Update () {



		if (Input.GetKeyDown (KeyCode.G)) {
			
			if (greenPlaneInside) {
				iTween.MoveTo (greenPlane, iTween.Hash ("x", -640F, "easetype", iTween.EaseType.easeInOutExpo, "time", 5F));
			} else {
				SetPlaneAsForeground (0);
				iTween.MoveTo (greenPlane, iTween.Hash ("x", 640F, "easetype", iTween.EaseType.easeInOutExpo, "time", 5F));
			}
			greenPlaneInside = !greenPlaneInside;
		}

		if (Input.GetKeyDown (KeyCode.P)) {
			
			if (purplePlaneInside) {
				iTween.MoveTo (purplePlane, iTween.Hash ("x", -640F, "easetype", iTween.EaseType.easeInOutExpo, "time", 5F));
			} else {
				SetPlaneAsForeground (1);
				iTween.MoveTo (purplePlane, iTween.Hash ("x", 640F, "easetype", iTween.EaseType.easeInOutExpo, "time", 5F));
			}
			purplePlaneInside = !purplePlaneInside;
		}




	}


	void SetPlaneAsForeground(int number) {
		_background.GetComponentInChildren<RectTransform> ().transform.SetParent (_tmp.transform);
		_foreground.GetComponentInChildren<RectTransform> ().transform.SetParent (_background.transform);

		if (number == 0) {
			greenPlane.transform.SetParent (_foreground.transform);
		} else if (number == 1) {
			
			purplePlane.transform.SetParent (_foreground.transform);
		}

	}


}
