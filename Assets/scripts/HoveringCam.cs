using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HoveringCam : MonoBehaviour {

	public Image BTN_running;
	public Color standardColor; 
	public Color highlightedColor;
	public Text durationWorldChangeTXT;
	private float durationWorldChange;

	public Image hoveringReady;

	public Color colorRed; 
	public Color colorOrange;

	private float xMax; 
	private float yMax; 

	private float xCurrent; 
	private float yCurrent;

	private float xTMP; 
	private float yTMP;

	private float xZero; 
	private float yZero;

	private float currentSpeed;

	private float currentSpeedRunning;

	public float currentDistance;
	public Slider mainSlider;
	public Image currentlyRunning;
	private float counter;

	private bool running;

	private bool atZero;
	private bool atZeroX;
	private bool atZeroY;

	private bool focus;

	private bool runningMaster;


	private Vector3 startPosition;

	// Use this for initialization
	void Start () {

		currentlyRunning.CrossFadeAlpha (0F, 0F, false);

		counter = 0F;

		hoveringReady.color = colorRed;

		mainSlider.onValueChanged.AddListener (delegate {ValueChangeCheck ();});

		runningMaster = true;
		BTN_running.color = highlightedColor;

		currentSpeed = 0.00015F;

		currentSpeedRunning = 10F;

		currentDistance = 2F;

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
				rotateRunning ();
				xTMP = getX ();
				yTMP = getY ();
				transform.localPosition = new Vector3 (startPosition.x + xTMP, startPosition.y + yTMP, startPosition.z + yTMP); 
			}
		}
	}

	private void rotateRunning() {
		if (counter > currentSpeedRunning) {
			currentlyRunning.transform.Rotate(0,0, -45);
			counter = 0F;
		}

		counter++;
	}
		

	private void resetValues() {
		while (!atZero) {

			if (!atZeroX) {
				xTMP = getX ();
				if (xTMP < 0.01F && xTMP > -0.01) {
					atZeroX = true;
					xCurrent = xCurrent - currentSpeed;
					xZero = xCurrent; 
				}
			}
			if (!atZeroY) {
				yTMP = getY ();
				if (yTMP < 0.01F && yTMP > -0.01) {
					atZeroY = true;
					yCurrent = yCurrent - currentSpeed;
					yZero = yCurrent;
				}
			}

			if (atZeroX && atZeroY) {
				atZero = true;
			}currentlyRunning.CrossFadeAlpha (0F, 0F, false);
		}
	}

	//speed adjust

	public void setSpeed(float inputValue) {
		currentSpeed = RemapRange (inputValue, 0F, 1F, 0.00015F, 0.0004F);

		currentSpeedRunning = RemapRange (inputValue, 0F, 1F, 20F, 5F);

		//Debug.Log (currentSpeed);
	}

	public void ValueChangeCheck()
	{
		setSpeed(mainSlider.value);
	}

	private float RemapRange (float value, float from1, float to1, float from2, float to2) {
		return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
	}


	float getX() {
		xCurrent = xCurrent + currentSpeed;
		if(xCurrent == 1F)
			xCurrent = 0F;
		return (Mathf.PerlinNoise(xCurrent, 0.5F) - 0.5F) * currentDistance;
	}


	float getY() {
		yCurrent = yCurrent + currentSpeed;
			if(yCurrent == 1F) 
				yCurrent = 0F;
		return (Mathf.PerlinNoise(0.1F, yCurrent)-0.5F) * currentDistance;
	}


	public void startHoveringAtBeginning() {
		//onlocation
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
		currentlyRunning.CrossFadeAlpha (0F, 0F, false);
		xCurrent = xZero; 
		yCurrent = yZero;
	}

	public void focusCamera() {
		if (focus) {
			hoveringReady.color = colorOrange;
			StartCoroutine (waitBeforeReady ());
			iTween.MoveTo (this.gameObject, iTween.Hash ("position", startPosition, "easetype", iTween.EaseType.easeInOutQuad, "time", 10F, "islocal", true));
		}
	}

	private IEnumerator waitBeforeReady() {
		yield return new WaitForSeconds (10F);
		hoveringReady.color = highlightedColor;
	}


	public void stopHoveringAndContinue() {
		running = false;
		currentlyRunning.CrossFadeAlpha (0F, 0.5F, false);
	}

	public void continueHovering() {
		running = true;
		currentlyRunning.CrossFadeAlpha (1F, 0.5F, false);
	}


	private IEnumerator startHoveringDelay(float delay) {
		yield return new WaitForSeconds (delay);
		hoveringReady.color = colorRed;
		focus = true;
		startPosition = transform.localPosition;
		running = true;
		currentlyRunning.CrossFadeAlpha (1F, 0.5F, false);
	}

	public void setMasterRunning() {
		if (runningMaster) {
			runningMaster = false;
			currentlyRunning.CrossFadeAlpha (0F, 0F, false);
			BTN_running.color = standardColor;
		} else {
			runningMaster = true;
			currentlyRunning.CrossFadeAlpha (1F, 0.5F, false);
			BTN_running.color = highlightedColor;
		}
	}



}
