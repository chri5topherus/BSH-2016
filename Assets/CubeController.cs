using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	public GameObject cubeRed; 
	public GameObject cubeYellow; 

	private Vector3 startPositionBottom; 
	private Vector3 startPositionTop; 

	private bool setting01Visible;
	private bool setting02Visible;

	// Use this for initialization
	void Start () {
		startPositionBottom = cubeYellow.transform.localPosition;
		startPositionTop = cubeRed.transform.localPosition;

		setting01Visible = true; 
		setting02Visible = false;

		showSetting01 ();
	}


	public void showSetting01() {
		if (setting01Visible) {
			iTween.MoveTo(cubeYellow, iTween.Hash("y",  startPositionBottom.y+10F, "time", 2F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 0.5F));
			iTween.MoveTo(cubeRed, iTween.Hash("y",  startPositionTop.y+10F, "time", 2F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true));

			iTween.RotateBy(cubeRed, iTween.Hash("y",  1F, "time", 2F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true ));
			iTween.RotateBy(cubeYellow, iTween.Hash("y",  1F, "time", 2F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 0.5F));
		} else { 
			iTween.MoveTo(cubeYellow, iTween.Hash("y",  startPositionBottom.y, "time", 2F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true));
			iTween.MoveTo(cubeRed, iTween.Hash("y",  startPositionTop.y, "time", 2F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true , "delay", 0.5F));

			iTween.RotateBy(cubeRed, iTween.Hash("y",  1F, "time", 2F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true , "delay", 0.5F));
			iTween.RotateBy(cubeYellow, iTween.Hash("y",  1F, "time", 2F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true));
		}

		setting01Visible = !setting01Visible;
	}

	public void showSetting02() {
		if (setting02Visible) {
			iTween.MoveTo(cubeRed, iTween.Hash("y",  startPositionBottom.y+10F, "time", 2F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 0.5F));
			iTween.MoveTo(cubeYellow, iTween.Hash("y",  startPositionTop.y+10F, "time", 2F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true));

			iTween.RotateBy(cubeYellow, iTween.Hash("y",  1F, "time", 2F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true ));
			iTween.RotateBy(cubeRed, iTween.Hash("y",  1F, "time", 2F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 0.5F));
		} else { 
			iTween.MoveTo(cubeRed, iTween.Hash("y",  startPositionBottom.y, "time", 2F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true));
			iTween.MoveTo(cubeYellow, iTween.Hash("y",  startPositionTop.y, "time", 2F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true , "delay", 0.5F));

			iTween.RotateBy(cubeYellow, iTween.Hash("y",  1F, "time", 2F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true , "delay", 0.5F));
			iTween.RotateBy(cubeRed, iTween.Hash("y",  1F, "time", 2F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true));
		}

		setting02Visible = !setting02Visible;
	}



}
