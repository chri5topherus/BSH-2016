using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HoveringCam : MonoBehaviour {

	public Image BTN_running;
	public Color standardColor; 
	public Color highlightedColor;
	public Text durationWorldChangeTXT;
	private float durationWorldChange;

	private float xMax; 
	private float yMax; 

	private float xCurrent; 
	private float yCurrent;

	private float xTMP; 
	private float yTMP;

	private float xZero; 
	private float yZero;

	private bool running;

	private bool atZero;
	private bool atZeroX;
	private bool atZeroY;

	private bool focus;

	private bool runningMaster;


	private Vector3 startPosition;

	// Use this for initialization
	void Start () {

		runningMaster = true;
		BTN_running.color = highlightedColor;

		atZero = false;
		atZeroX = false;
		atZeroY = false;

		xZero = 0F; 
		yZero = 0F;

		xCurrent = 0F; 
		yCurrent = 0.5F;

		running = false;
		startPosition = transform.localPosition;

		focus = false;

		//start looking for zero values 
		resetValues();
	}
	
	// Update is called once per frame
	void Update () {

		if (runningMaster) {
			if (running) {
				xTMP = getX ();
				yTMP = getY ();
				transform.localPosition = new Vector3 (startPosition.x + xTMP, startPosition.y + yTMP, startPosition.z + yTMP); 
			}
		}
	}
		

	private void resetValues() {
		while (!atZero) {

			if (!atZeroX) {
				xTMP = getX ();
				if (xTMP < 0.01F && xTMP > -0.01) {
					atZeroX = true;
					xCurrent = xCurrent - 0.002F;
					xZero = xCurrent; 
				}
			}
			if (!atZeroY) {
				yTMP = getY ();
				if (yTMP < 0.01F && yTMP > -0.01) {
					atZeroY = true;
					yCurrent = yCurrent - 0.002F;
					yZero = yCurrent;
				}
			}

			if (atZeroX && atZeroY) {
				atZero = true;
			}
		}
	}


	float getX() {
		xCurrent = xCurrent + 0.002F;
		if(xCurrent == 1F)
			xCurrent = 0F;
		return (Mathf.PerlinNoise(xCurrent, 0.5F) - 0.5F) * 5F;
	}


	float getY() {
		yCurrent = yCurrent + 0.002F;
			if(yCurrent == 1F) 
				yCurrent = 0F;
		return (Mathf.PerlinNoise(0.1F, yCurrent)-0.5F) * 5F;
	}


	public void startHoveringAtBeginning() {
		//added 2 sec
		StartCoroutine (startHoveringDelay (10F));
	}

	public void startHoveringManually(){
		StartCoroutine (startHoveringDelay (0F));
	}

	public void startHoveringAfterWorldChange(){
		durationWorldChange = float.Parse (durationWorldChangeTXT.text);
		StartCoroutine (startHoveringDelay (durationWorldChange+1F));
	}


	public void stopHovering() {
		focus = false;
		running = false;
		xCurrent = xZero; 
		yCurrent = yZero;
	}

	public void focusCamera() {
		if (focus) {
			iTween.MoveTo (this.gameObject, iTween.Hash ("position", startPosition, "easetype", iTween.EaseType.easeInOutQuad, "time", 10F, "islocal", true));
		}
	}


	public void stopHoveringAndContinue() {
		running = false;
	}

	public void continueHovering() {
		running = true;

	}


	private IEnumerator startHoveringDelay(float delay) {
		yield return new WaitForSeconds (delay);
		focus = true;
		startPosition = transform.localPosition;
		running = true;
	}

	public void setMasterRunning() {
		if (runningMaster) {
			runningMaster = false;
			BTN_running.color = standardColor;
		} else {
			runningMaster = true;
			BTN_running.color = highlightedColor;
		}
	}



}
