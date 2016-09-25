using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CubeController : MonoBehaviour {

	public GameObject cubeRed; 
	public GameObject cubeYellow; 

	private Vector3 startPositionBottom; 
	private Vector3 startPositionTop; 

	private bool setting01Visible;
	private bool setting02Visible;

	// logo animation
	public GameObject cubeLogo01; 
	public GameObject cubeLogo02; 
	public GameObject cubeLogo03; 
	public GameObject cubeLogo04; 

	private bool logoVisible;

	private Vector3 startPositionCubeLogo01;
	private Vector3 startPositionCubeLogo02;
	private Vector3 startPositionCubeLogo03;
	private Vector3 startPositionCubeLogo04;

	public Color standardColor; 
	public Color highlightedColor;

	public Image BTN_showLogo; 

	// Use this for initialization
	void Start () {
		startPositionBottom = cubeYellow.transform.localPosition;
		startPositionTop = cubeRed.transform.localPosition;

		setting01Visible = true; 
		setting02Visible = false;

		showSetting01 ();

		startPositionCubeLogo01 = cubeLogo01.transform.localPosition;
		startPositionCubeLogo02 = cubeLogo02.transform.localPosition;
		startPositionCubeLogo03 = cubeLogo03.transform.localPosition;
		startPositionCubeLogo04 = cubeLogo04.transform.localPosition;

		logoVisible = true;
		BTN_showLogo.color = highlightedColor;
		//showLogo ();
	}

	//theme cubes
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

	//theme cubes
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

	public void showLogo() {
		if (!logoVisible) {
			BTN_showLogo.color = highlightedColor;

			iTween.MoveTo (cubeLogo01, iTween.Hash ("z", startPositionCubeLogo01.z, "time", 5F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 0F));
			iTween.MoveTo (cubeLogo02, iTween.Hash ("z", startPositionCubeLogo02.z, "time", 5F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 0.5F));
			iTween.MoveTo (cubeLogo03, iTween.Hash ("z", startPositionCubeLogo03.z, "time", 5F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 1F));
			iTween.MoveTo (cubeLogo04, iTween.Hash ("z", startPositionCubeLogo04.z, "time", 5F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 1.5F));

			iTween.RotateTo (cubeLogo01, iTween.Hash ("x", 1440F, "time", 5F, "easetype", iTween.EaseType.easeInOutQuart, "delay", 0F));
			iTween.RotateTo (cubeLogo02, iTween.Hash ("x", 1440F, "time", 5F, "easetype", iTween.EaseType.easeInOutQuart, "delay", 0.5F));
			iTween.RotateTo (cubeLogo03, iTween.Hash ("x", 1440F, "time", 5F, "easetype", iTween.EaseType.easeInOutQuart, "delay", 1F));
			iTween.RotateTo (cubeLogo04, iTween.Hash ("x", 1440F, "time", 5F, "easetype", iTween.EaseType.easeInOutQuart, "delay", 1.5F));
		} else {
			BTN_showLogo.color = standardColor;

			iTween.MoveTo(cubeLogo04, iTween.Hash("z",  startPositionCubeLogo01.z-50F, "time", 5F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 0F));
			iTween.MoveTo(cubeLogo03, iTween.Hash("z",  startPositionCubeLogo02.z-50F, "time", 5F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 0.5F));
			iTween.MoveTo(cubeLogo02, iTween.Hash("z",  startPositionCubeLogo03.z-50F, "time", 5F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 1F));
			iTween.MoveTo(cubeLogo01, iTween.Hash("z",  startPositionCubeLogo04.z-50F, "time", 5F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 1.5F));

			iTween.RotateTo(cubeLogo04, iTween.Hash("x",  -1440F, "time", 5F, "easetype", iTween.EaseType.easeInOutQuart, "delay", 0F));
			iTween.RotateTo(cubeLogo03, iTween.Hash("x",  -1440F, "time", 5F, "easetype", iTween.EaseType.easeInOutQuart, "delay", 0.5F));
			iTween.RotateTo(cubeLogo02, iTween.Hash("x",  -1440F, "time", 5F, "easetype", iTween.EaseType.easeInOutQuart, "delay", 1F));
			iTween.RotateTo(cubeLogo01, iTween.Hash("x",  -1440F, "time", 5F, "easetype", iTween.EaseType.easeInOutQuart, "delay", 1.5F));
		}
		logoVisible = !logoVisible;
	}


}
