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

	private Vector3 startPositionCubeLogo01;
	private Vector3 startPositionCubeLogo02;
	private Vector3 startPositionCubeLogo03;
	private Vector3 startPositionCubeLogo04;

	public Color standardColor; 
	public Color highlightedColor;

	public Image BTN_showLogo; 
	public Image BTN_hideLogo;

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

		hideLogo ();
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

	public void showLogo() {

		BTN_showLogo.color = highlightedColor;
		BTN_hideLogo.color = standardColor;

		iTween.MoveTo(cubeLogo01, iTween.Hash("z",  startPositionCubeLogo01.z, "time", 3F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 0F));
		iTween.MoveTo(cubeLogo02, iTween.Hash("z",  startPositionCubeLogo02.z, "time", 3F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 0.5F));
		iTween.MoveTo(cubeLogo03, iTween.Hash("z",  startPositionCubeLogo03.z, "time", 3F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 1F));
		iTween.MoveTo(cubeLogo04, iTween.Hash("z",  startPositionCubeLogo04.z, "time", 3F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 1.5F));

		iTween.RotateBy(cubeLogo01, iTween.Hash("x",  1F, "time", 3F, "easetype", iTween.EaseType.easeInOutQuart, "delay", 0F));
		iTween.RotateBy(cubeLogo02, iTween.Hash("x",  1F, "time", 3F, "easetype", iTween.EaseType.easeInOutQuart, "delay", 0.5F));
		iTween.RotateBy(cubeLogo03, iTween.Hash("x",  1F, "time", 3F, "easetype", iTween.EaseType.easeInOutQuart, "delay", 1F));
		iTween.RotateBy(cubeLogo04, iTween.Hash("x",  1F, "time", 3F, "easetype", iTween.EaseType.easeInOutQuart, "delay", 1.5F));
	}


	public void hideLogo() {

		BTN_showLogo.color = standardColor;
		BTN_hideLogo.color = highlightedColor;

		iTween.MoveTo(cubeLogo04, iTween.Hash("z",  startPositionCubeLogo01.z-15F, "time", 3F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 0F));
		iTween.MoveTo(cubeLogo03, iTween.Hash("z",  startPositionCubeLogo02.z-15F, "time", 3F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 0.5F));
		iTween.MoveTo(cubeLogo02, iTween.Hash("z",  startPositionCubeLogo03.z-15F, "time", 3F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 1F));
		iTween.MoveTo(cubeLogo01, iTween.Hash("z",  startPositionCubeLogo04.z-15F, "time", 3F, "easetype", iTween.EaseType.easeInOutQuart, "islocal", true, "delay", 1.5F));

		iTween.RotateBy(cubeLogo04, iTween.Hash("x",  -1F, "time", 3F, "easetype", iTween.EaseType.easeInOutQuart, "delay", 0F));
		iTween.RotateBy(cubeLogo03, iTween.Hash("x",  -1F, "time", 3F, "easetype", iTween.EaseType.easeInOutQuart, "delay", 0.5F));
		iTween.RotateBy(cubeLogo02, iTween.Hash("x",  -1F, "time", 3F, "easetype", iTween.EaseType.easeInOutQuart, "delay", 1F));
		iTween.RotateBy(cubeLogo01, iTween.Hash("x",  -1F, "time", 3F, "easetype", iTween.EaseType.easeInOutQuart, "delay", 1.5F));
	}


}
