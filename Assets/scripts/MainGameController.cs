﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class MainGameController : MonoBehaviour {


	[Header ("------ camera objects ------")]

	public GameObject mainCam2D; 
	public GameObject mainCam3D;

	public GameObject mainCam3D01;
	public GameObject mainCam3D02;
	public GameObject mainCam3D03;

	private float mainCam3D01_startPos;
	private float mainCam3D02_startPos;
	private float mainCam3D03_startPos;

	public Text rebuildTime; 
	public Text rebuildDistance;

	public Image BTN_rebuild01;
	public Image BTN_rebuild02;
	public Image BTN_rebuild03;

	private Vector3 mainCam3DstartPos;

	[Header ("------ chapter headlines ------")]

	public Text strategieTXT;
	public Text bauTXT;
	public Text digiTXT;
	public Text vertriebTXT;
	public Text roboterTXT;

	private float strategieTXTstartPos;
	private float bauTXTstartPos;
	private float digiTXTstartPos;
	private float vertriebTXTstartPos;
	private float roboterTXTstartPos;

	public Image BTN_strategieON; 
	public Image BTN_strategieOFF;
	public Image BTN_baufinanzON; 
	public Image BTN_baufinanzOFF;
	public Image BTN_digiON;
	public Image BTN_digiOFF;
	public Image BTN_vertriebON;
	public Image BTN_vertriebOFF;
	public Image BTN_roboterON; 
	public Image BTN_roboterOFF; 


	private float animationDuration = 2F;

	[Header ("------ bauchbinde ------")]

	//bauchbinden 
	public InputField inputTextBauchbinde01;
	public InputField inputTextBauchbinde02;
	public InputField inputTextBauchbinde03;
	public InputField inputTextBauchbinde04;
	public InputField inputTextBauchbinde05;
	public InputField inputTextBauchbinde06;
	public InputField inputTextBauchbinde07;
	public InputField inputTextBauchbinde08;
	public InputField inputTextBauchbinde09;
	public InputField inputTextBauchbinde10;

	public InputField inputTextBauchbindeTitle01;
	public InputField inputTextBauchbindeTitle02;
	public InputField inputTextBauchbindeTitle03;
	public InputField inputTextBauchbindeTitle04;
	public InputField inputTextBauchbindeTitle05;
	public InputField inputTextBauchbindeTitle06;
	public InputField inputTextBauchbindeTitle07;
	public InputField inputTextBauchbindeTitle08;
	public InputField inputTextBauchbindeTitle09;
	public InputField inputTextBauchbindeTitle10;


	public Text TXT_bauchbinde01;
	public Text TXT_bauchbinde02;
	public GameObject bauchbinde;
	private bool visibleBauchbinde;
	private float bauchbindeStartPos;

	public Image BTN_bauchbinde;
	public Image BTN_bauchbindeShow;


	[Header ("------ phone off ------")]

	//bauchbinden 
	public Text phoneOff;
	private bool phoneOffVisible;
	public Image BTNphone;


	[Header ("------ pause logos ------")]

	//bauchbinden 
	public Image pauseOff01;
	public Image pauseOff02;



	[Header ("------ questions ------")]

	//fields for controll interface
	public InputField inputTextQuestion;
	public InputField inputTextAnswer01;
	public InputField inputTextAnswer02;
	public InputField inputTextAnswer03;
	public InputField inputTextAnswer04;

	public Text[] TXT_00_allresultArray = new Text[3];
	public Text[] TXT_01_allresultArray = new Text[3];
	public Text[] TXT_02_allresultArray = new Text[3];
	public Text[] TXT_03_allresultArray = new Text[3];
	public Text[] TXT_04_allresultArray = new Text[3];
	public Text[] TXT_05_allresultArray = new Text[3];
	public Text[] TXT_06_allresultArray = new Text[3];

	public Text[] TXT_00_resultLeftArray = new Text[3];
	public Text[] TXT_01_resultLeftArray = new Text[3];
	public Text[] TXT_02_resultLeftArray = new Text[3];
	public Text[] TXT_03_resultLeftArray = new Text[3];
	public Text[] TXT_04_resultLeftArray = new Text[3];
	public Text[] TXT_05_resultLeftArray = new Text[3];
	public Text[] TXT_06_resultLeftArray = new Text[3];


	// translation objects
	public GameObject _question00;
	public GameObject _result00;

	public GameObject _question01;
	public GameObject _result01;

	public GameObject _question02;
	public GameObject _result02;

	public GameObject _question03;
	public GameObject _result03;

	public GameObject _question04;
	public GameObject _result04;

	public GameObject _question05;
	public GameObject _result05;

	public GameObject _question06;
	public GameObject _result06;

	private bool showedResults;

	//questions array
	private int currentQuestion;

	[Header ("------ q counter ------")]

	public Text TXT_currentQuestion;
	private string [,] questions;



	[Header ("------ results ------")]


	//color of results 
	public Color color01purple; 
	public Color color02blue; 
	public Color color03green; 
	public Color color00black;

	//results
	public Text resultError;
	private float result01; 
	private float result02; 
	private float result03; 
	//private float result04; 

	public float spaceBetweenCubes;
	public float scaleIndex;

	public string currentResultString; 
	public float currentResultFloat;
	public int currentResultColor;

	public InputField inputResult01;
	public InputField inputResult02;
	public InputField inputResult03;
	public InputField inputResult04;

	public Image BTNshow;
	public Image BTNcountdown;
	public Image BTNresults;
	public Image BTNremove;

	public Color standardButtonColor; 
	public Color highlightedButtonColor;
	public Color highlightedButtonColorYellow;
	public Color lightGreyButtonColor;

	private int activeButtonCounter;


	[Header ("------ cube objects ------")]

	//objects

	private Vector3 testCube1startPosition;
	private Vector3 cubeQ01startPosition;
	private Vector3 cubeQ02startPosition;
	private Vector3 cubeQ03startPosition;
	private Vector3 cubeQ04startPosition;
	private Vector3 cubeQ05startPosition;
	private Vector3 cubeQ06startPosition;

	//public GameObject testCube1;
	public GameObject testCube2;
	public GameObject testCube3;
	public GameObject testCube4;

	public GameObject cubeQ01_01;
	public GameObject cubeQ01_02;
	public GameObject cubeQ01_03;

	public GameObject cubeQ02_01;
	public GameObject cubeQ02_02;
	public GameObject cubeQ02_03;

	public GameObject cubeQ03_01;
	public GameObject cubeQ03_02;
	public GameObject cubeQ03_03;

	public GameObject cubeQ04_01;
	public GameObject cubeQ04_02;
	public GameObject cubeQ04_03;

	public GameObject cubeQ05_01;
	public GameObject cubeQ05_02;
	public GameObject cubeQ05_03;

	public GameObject cubeQ06_01;
	public GameObject cubeQ06_02;
	public GameObject cubeQ06_03;



	// Use this for initialization
	void Start () {

		BTN_rebuild01.color = highlightedButtonColor;

		mainCam3DstartPos = new Vector3 (mainCam3D.transform.position.x, mainCam3D.transform.position.y, mainCam3D.transform.position.z);
		testCube1startPosition = testCube2.transform.position;
		cubeQ01startPosition = cubeQ01_01.transform.position;
		cubeQ02startPosition = cubeQ02_01.transform.position;
		cubeQ03startPosition = cubeQ03_01.transform.position;
		cubeQ04startPosition = cubeQ04_01.transform.position;
		cubeQ05startPosition = cubeQ05_01.transform.position;
		cubeQ06startPosition = cubeQ06_01.transform.position;


		// ---- PHONE OFF ----
		phoneOffVisible = false;
		BTNphone.color = standardButtonColor;
		phoneOff.CrossFadeAlpha (0F, 0F, false);


		// ---- PAUSE ---- 
		pauseOff01.CrossFadeAlpha (1F, 0F, false);
		pauseOff02.CrossFadeAlpha (0F, 0F, false);


		// ---- HEADLINES ----
		strategieTXTstartPos = strategieTXT.GetComponent<RectTransform> ().anchoredPosition.x;
		bauTXTstartPos = bauTXT.GetComponent<RectTransform> ().anchoredPosition.x;
		digiTXTstartPos = digiTXT.GetComponent<RectTransform> ().anchoredPosition.x;
		vertriebTXTstartPos = vertriebTXT.GetComponent<RectTransform> ().anchoredPosition.x;
		roboterTXTstartPos = roboterTXT.GetComponent<RectTransform> ().anchoredPosition.x;



		// ---- HEADLINES OFF ----
		iTween.MoveTo (strategieTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", 0F));
		iTween.MoveTo (bauTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", 0F));
		iTween.MoveTo (digiTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", 0F));
		iTween.MoveTo (vertriebTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", 0F));
		iTween.MoveTo (roboterTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", 0F));

		BTN_strategieOFF.color = highlightedButtonColor;
		BTN_baufinanzOFF.color = highlightedButtonColor;
		BTN_digiOFF.color = highlightedButtonColor;
		BTN_vertriebOFF.color = highlightedButtonColor;
		BTN_roboterOFF.color = highlightedButtonColor;


		// ---- BAUCHBINDEN ----
		bauchbindeStartPos = bauchbinde.transform.position.y;
		inputTextBauchbinde01.text = "Reinhard Klein";
		inputTextBauchbinde02.text = "Gerhard Hinterberger";
		inputTextBauchbinde03.text = "Sabine Baron";
		inputTextBauchbinde04.text = "Kristin Seyboth";
		inputTextBauchbinde05.text = "Jochen Maier";
		inputTextBauchbinde06.text = "Thomas Schüttler";
		inputTextBauchbinde07.text = "Professor Dr. Christian Rieck";
		inputTextBauchbinde08.text = "Stephan Lohß";
		inputTextBauchbinde09.text = "Nova Meierhenrich";
		inputTextBauchbinde10.text = "empty";

		inputTextBauchbindeTitle01.text = "Vorstandsvorsitzender";
		inputTextBauchbindeTitle02.text = "Vorstandsmitglied";
		inputTextBauchbindeTitle03.text = "Bereichsleitung Vertrieb";
		inputTextBauchbindeTitle04.text = "Bereichsleiterin Kredit- und Sparbereiche ";
		inputTextBauchbindeTitle05.text = "Bereichsleiter Marketing";
		inputTextBauchbindeTitle06.text = "Bereichsberater Projekte DZ-Bank Konzern";
		inputTextBauchbindeTitle07.text = "Professor für Finance und Wirtschaftstheorie an der Frankfurt University of Applied Sciences";
		inputTextBauchbindeTitle08.text = "Bezirksleiter Baufinanzierung";
		inputTextBauchbindeTitle09.text = "Moderatorin";
		inputTextBauchbindeTitle10.text = "empty10";

		BTN_bauchbinde.color = highlightedButtonColor;
		BTN_bauchbindeShow.color = lightGreyButtonColor;
		visibleBauchbinde = false;
		hideBauchbinde ();

		// ---- RESULTS ----
		fadeOutResults (TXT_00_allresultArray);
		fadeOutResults (TXT_01_allresultArray);
		fadeOutResults (TXT_02_allresultArray);
		fadeOutResults (TXT_03_allresultArray);
		fadeOutResults (TXT_04_allresultArray);
		fadeOutResults (TXT_05_allresultArray);
		fadeOutResults (TXT_06_allresultArray);

		fadeColorToBlack (TXT_00_resultLeftArray);
		fadeColorToBlack (TXT_01_resultLeftArray);
		fadeColorToBlack (TXT_02_resultLeftArray);
		fadeColorToBlack (TXT_03_resultLeftArray);
		fadeColorToBlack (TXT_04_resultLeftArray);
		fadeColorToBlack (TXT_05_resultLeftArray);
		fadeColorToBlack (TXT_06_resultLeftArray);

		showedResults = false;
		activeButtonCounter = 1;

		BTNshow.color = highlightedButtonColorYellow;

		TXT_currentQuestion.text = "0 / 6";

		spaceBetweenCubes = 0.2F;
		scaleIndex = 6.12f;

	
		// set question text
		questions = new string[,]{
			{ "Was möchten Sie heute Abend trinken?", "A Bier", "B Wein", "C Wasser" }, 
			{ "Braucht die genossenschaftliche FinanzGruppe eine klare Strategie für den Umgang mit Finanzierungs-Plattformen?", "A Ja", "B Nein", "C Weiß nicht" }, 
			{ "Frage 4", "nicht gut", "gut", "..."},
			{ "Welchen Marktanteil können wir gemeinsam in 2021 realisieren?", "A 20% Marktanteil", "B 25% Marktanteil", "C 30% Marktanteil" }, 
			{ "Bis zu welcher Bonitätsklasse nach der BVR-Masterskala vergeben aus Ihrer Sicht der Großteil der Banken normalerweise Baufinanzierungen?", "A bis 2B", "B bis 2D", "C bis 3B"},
			{ "Ist das vorgestellte modulare Angebot an Außendienstfunktionen der richtige Weg für die weitere Zusammenarbeit?", "A Ja", "B Nein", "C Weiß nicht" },
			{ "Setzen Sie die genossenschaftliche Beratung in Ihrer Bank bereits um?", "A Ja, in vollem Umfang", "B Noch nicht - aber in Vorbereitung", "C Nein"}
		};


		// ----- QUESTION ------
		currentQuestion = 0;
		//set first question in input fields
		refreshQuestion ();
		resetCubes (testCube2, testCube3, testCube4, testCube1startPosition);
		resetCubes (cubeQ01_01, cubeQ01_02, cubeQ01_03, cubeQ01startPosition);
		resetCubes (cubeQ02_01, cubeQ02_02, cubeQ02_03, cubeQ02startPosition);
		resetCubes (cubeQ03_01, cubeQ03_02, cubeQ03_03, cubeQ03startPosition);
		resetCubes (cubeQ04_01, cubeQ04_02, cubeQ04_03, cubeQ04startPosition);
		resetCubes (cubeQ05_01, cubeQ05_02, cubeQ05_03, cubeQ05startPosition);
		resetCubes (cubeQ06_01, cubeQ06_02, cubeQ06_03, cubeQ06startPosition);

			

		// ----- QUESTION POSITION - NOT VISIBLE ------ 
		moveQuestionsInOut(_question00, _result00, false, 0F, 0F);	
		moveQuestionsInOut(_question01, _result01, false, 0F, 0F);	
		moveQuestionsInOut(_question02, _result02, false, 0F, 0F);	
		moveQuestionsInOut(_question03, _result03, false, 0F, 0F);	
		moveQuestionsInOut(_question04, _result04, false, 0F, 0F);	
		moveQuestionsInOut(_question05, _result05, false, 0F, 0F);	
		moveQuestionsInOut(_question06, _result06, false, 0F, 0F);	


		//camera setup
		mainCam3D01_startPos = mainCam3D01.transform.localPosition.x;
		mainCam3D02_startPos = mainCam3D02.transform.localPosition.x;
		mainCam3D03_startPos = mainCam3D03.transform.localPosition.x;

	}
	
	// Update is called once per frame
	void Update () {
	
		/*
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Debug.Log ("up");
			StartCoroutine (startAnimatioresultsn ());
			iTween.MoveTo (mainCam3D, iTween.Hash ("position", new Vector3 (mainCam3D.transform.position.x + 1, mainCam3D.transform.position.y, mainCam3D.transform.transform.position.z), "easetype", iTween.EaseType.easeInOutExpo, "time", 1F));
		}
*/
			
	}




	#region phone

	public void showPhoneOff() {
		if (phoneOffVisible) {
			phoneOff.CrossFadeAlpha (0F, 1F, false);
			BTNphone.color = standardButtonColor;
		} else {
			phoneOff.CrossFadeAlpha (1F, 1F, false);
			BTNphone.color = highlightedButtonColor;
		}
		phoneOffVisible = !phoneOffVisible;
	}

	#endregion



	public void startPauseMode() {
		StartCoroutine (waitBeforePause ());
	}
		


	IEnumerator waitBeforePause() {
		yield return new WaitForSeconds (10F);
		showPause ();
	}



	public void showPause() {
		pauseOff02.CrossFadeAlpha (1F, 1F, false);
	}

	public void hidePause() {
		pauseOff01.CrossFadeAlpha (0F, 0F, false);
		pauseOff02.CrossFadeAlpha (0F, 1F, false);
	}


	public void switchPause() {
		pauseOff01.CrossFadeAlpha (0F, 0.5F, false);
		pauseOff02.CrossFadeAlpha (1F, 0.5F, false);
	}

	public void resetAll() {
		Start ();
		pauseOff01.CrossFadeAlpha (1F, 0.5F, false);
		pauseOff02.CrossFadeAlpha (0F, 0.5F, false);
	}


	#region rebuild

	public void rebuildModus00() {

		BTN_rebuild01.color = highlightedButtonColor;
		BTN_rebuild02.color = standardButtonColor;
		BTN_rebuild03.color = standardButtonColor;

		string tmp = rebuildTime.text; 
		float durationTmp;
		try{
			durationTmp = float.Parse (tmp);
			iTween.MoveTo(mainCam3D01, iTween.Hash("x",  mainCam3D01_startPos, "time", durationTmp, "easetype", iTween.EaseType.linear, "islocal", true));
			iTween.MoveTo(mainCam3D02, iTween.Hash("x",  mainCam3D02_startPos, "time", durationTmp, "easetype", iTween.EaseType.linear, "islocal", true));
			iTween.MoveTo(mainCam3D03, iTween.Hash("x",  mainCam3D03_startPos, "time", durationTmp, "easetype", iTween.EaseType.linear, "islocal", true));
		} catch(Exception e) { 
			Debug.Log (e);
		}

	}

	public void rebuildModus01() {

		BTN_rebuild01.color = standardButtonColor;
		BTN_rebuild02.color = highlightedButtonColor;
		BTN_rebuild03.color = standardButtonColor;

		string tmp = rebuildTime.text; 
		float durationTmp;
		float distanceTmp;
		try{
			durationTmp = float.Parse (tmp);
			string tmp2 = rebuildDistance.text; 
			distanceTmp = float.Parse (tmp2);
		distanceTmp = distanceTmp / 100f;
			iTween.MoveTo(mainCam3D01, iTween.Hash("x",  mainCam3D01_startPos - distanceTmp/2F, "time", durationTmp, "easetype", iTween.EaseType.linear, "islocal", true));
			iTween.MoveTo(mainCam3D02, iTween.Hash("x",  mainCam3D02_startPos + distanceTmp/2F, "time", durationTmp, "easetype", iTween.EaseType.linear, "islocal", true));
			iTween.MoveTo(mainCam3D03, iTween.Hash("x",  mainCam3D03_startPos + distanceTmp/2F, "time", durationTmp, "easetype", iTween.EaseType.linear, "islocal", true));
		} catch(Exception e) {
			Debug.Log (e);
		}

	}

	public void rebuildModus02() {

		BTN_rebuild01.color = standardButtonColor;
		BTN_rebuild02.color = standardButtonColor;
		BTN_rebuild03.color = highlightedButtonColor;

		string tmp = rebuildTime.text; 
		float durationTmp;
		float distanceTmp;
		try {
			durationTmp = float.Parse (tmp);
			string tmp2 = rebuildDistance.text; 
			distanceTmp = float.Parse (tmp2);
			distanceTmp = distanceTmp / 100f;
			iTween.MoveTo(mainCam3D01, iTween.Hash("x",  mainCam3D01_startPos - distanceTmp/2F, "time", durationTmp, "easetype", iTween.EaseType.linear, "islocal", true));
			iTween.MoveTo(mainCam3D02, iTween.Hash("x",  mainCam3D02_startPos, "time", durationTmp, "easetype", iTween.EaseType.linear, "islocal", true));
			iTween.MoveTo(mainCam3D03, iTween.Hash("x",  mainCam3D03_startPos + distanceTmp/2F, "time", durationTmp, "easetype", iTween.EaseType.linear, "islocal", true));
		} catch(Exception e) { 
			Debug.Log (e);
		}

	}

	#endregion


	#region bauchbinde

	public void showBauchbinde01() {
		if (!visibleBauchbinde) {
			changeButtonColorBauchbinde ();
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde01.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle01.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde02() {
		if (!visibleBauchbinde) {
			changeButtonColorBauchbinde ();
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde02.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle02.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde03() {
		if (!visibleBauchbinde) {
			changeButtonColorBauchbinde ();
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde03.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle03.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde04() {
		if (!visibleBauchbinde) {
			changeButtonColorBauchbinde ();
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde04.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle04.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde05() {
		if (!visibleBauchbinde) {
			changeButtonColorBauchbinde ();
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde05.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle05.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde06() {
		if (!visibleBauchbinde) {
			changeButtonColorBauchbinde ();
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde06.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle06.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde07() {
		if (!visibleBauchbinde) {
			changeButtonColorBauchbinde ();
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde07.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle07.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde08() {
		if (!visibleBauchbinde) {
			changeButtonColorBauchbinde ();
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde08.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle08.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde09() {
		if (!visibleBauchbinde) {
			changeButtonColorBauchbinde ();
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde09.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle09.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde10() {
		if (!visibleBauchbinde) {
			changeButtonColorBauchbinde ();
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde10.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle10.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void hideBauchbinde() {
		visibleBauchbinde = false;
		BTN_bauchbinde.color = highlightedButtonColor;
		BTN_bauchbindeShow.color = lightGreyButtonColor;
		iTween.MoveTo(bauchbinde, iTween.Hash("y", 500F , "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
	}


	private void changeButtonColorBauchbinde() {
		BTN_bauchbinde.color = standardButtonColor;
		BTN_bauchbindeShow.color = highlightedButtonColor;
	}

	#endregion


	#region question

	public void showQuestion() {

		BTNshow.color = standardButtonColor;
		BTNcountdown.color = highlightedButtonColorYellow;

		float delayTmp = 1F;
		if (currentQuestion == 0) {
			moveQuestionsInOut (_question00, _result00, true, 2F, delayTmp);
		} else if (currentQuestion == 1) {
			moveQuestionsInOut (_question01, _result01, true, 2F, delayTmp);
		} else if (currentQuestion == 2) {
			moveQuestionsInOut (_question02, _result02, true, 2F, delayTmp);
		} else if (currentQuestion == 3) {
			moveQuestionsInOut (_question03, _result03, true, 2F, delayTmp);
		} else if (currentQuestion == 4) {
			moveQuestionsInOut (_question04, _result04, true, 2F, delayTmp);
		} else if (currentQuestion == 5) {
			moveQuestionsInOut (_question05, _result05, true, 2F, delayTmp);
		} else {
			moveQuestionsInOut (_question06, _result06, true, 2F, delayTmp);
		}

	}

	private void refreshQuestion() {
		inputTextQuestion.text = questions[currentQuestion,0];
		inputTextAnswer01.text = questions[currentQuestion,1];
		inputTextAnswer02.text = questions[currentQuestion,2];
		inputTextAnswer03.text = questions[currentQuestion,3];
	}

	public void showNextQuestion() {
		if (currentQuestion < 6) {
			currentQuestion++;
			TXT_currentQuestion.text = (currentQuestion) + " / 6";
			refreshQuestion ();
		}
	}
		
	public void showPreviousQuestion() {
		if (currentQuestion > 0) {
			currentQuestion--;
			TXT_currentQuestion.text = (currentQuestion) + " / 6";
			refreshQuestion ();
		}
	}
		

	private void moveQuestionsInOut(GameObject ques, GameObject res, bool into, float duration, float delayBetween) {
		if (into) {
			iTween.MoveTo (ques, iTween.Hash ("y", 0, "easetype", iTween.EaseType.easeInOutExpo, "time", duration, "delay", 0F));
			iTween.MoveTo (res, iTween.Hash ("y", 0, "easetype", iTween.EaseType.easeInOutExpo, "time", duration, "delay", delayBetween));
		} else {
			iTween.MoveTo (ques, iTween.Hash ("y", -850F, "easetype", iTween.EaseType.easeInOutExpo, "time", duration, "delay", delayBetween));
			iTween.MoveTo (res, iTween.Hash ("y", -850F, "easetype", iTween.EaseType.easeInOutExpo, "time", duration, "delay", 0F));
		}
	}


	public void removeResults() {

		BTNremove.color = standardButtonColor;
		BTNshow.color = highlightedButtonColorYellow;

			float delayTmp = 0F;
			if (currentQuestion == 0) {
				moveQuestionsInOut (_question00, _result00, false, 2F, delayTmp);
			} else if (currentQuestion == 1) {
				moveQuestionsInOut (_question01, _result01, false, 2F, delayTmp);
			} else if (currentQuestion == 2) {
				moveQuestionsInOut (_question02, _result02, false, 2F, delayTmp);
			} else if (currentQuestion == 3) {
				moveQuestionsInOut (_question03, _result03, false, 2F, delayTmp);
			} else if (currentQuestion == 4) {
				moveQuestionsInOut (_question04, _result04, false, 2F, delayTmp);
			} else if (currentQuestion == 5) {
				moveQuestionsInOut (_question05, _result05, false, 2F, delayTmp);
			} else {
				moveQuestionsInOut (_question06, _result06, false, 2F, delayTmp);
			}
			resultError.text = "";
			resetCubesAnimated (testCube2, testCube3, testCube4, testCube1startPosition);
			resetCubesAnimated (cubeQ01_01, cubeQ01_02, cubeQ01_03, cubeQ01startPosition);
			resetCubesAnimated (cubeQ02_01, cubeQ02_02, cubeQ02_03, cubeQ02startPosition);
			resetCubesAnimated (cubeQ03_01, cubeQ03_02, cubeQ03_03, cubeQ03startPosition);
			resetCubesAnimated (cubeQ04_01, cubeQ04_02, cubeQ04_03, cubeQ04startPosition);
			resetCubesAnimated (cubeQ05_01, cubeQ05_02, cubeQ05_03, cubeQ05startPosition);
			resetCubesAnimated (cubeQ06_01, cubeQ06_02, cubeQ06_03, cubeQ06startPosition);

		if (showedResults) {
			showNextQuestion ();
			StartCoroutine (removeResultsAfter (2F));
			showedResults = false;
		}
	}

	IEnumerator removeResultsAfter(float wait) {
		yield return new WaitForSeconds (wait);
		fadeOutResults (TXT_00_allresultArray);
		fadeOutResults (TXT_01_allresultArray);
		fadeOutResults (TXT_02_allresultArray);
		fadeOutResults (TXT_03_allresultArray);
		fadeOutResults (TXT_04_allresultArray);
		fadeOutResults (TXT_05_allresultArray);
		fadeOutResults (TXT_06_allresultArray);

		fadeColorToBlack (TXT_00_resultLeftArray);
		fadeColorToBlack (TXT_01_resultLeftArray);
		fadeColorToBlack (TXT_02_resultLeftArray);
		fadeColorToBlack (TXT_03_resultLeftArray);
		fadeColorToBlack (TXT_04_resultLeftArray);
		fadeColorToBlack (TXT_05_resultLeftArray);
		fadeColorToBlack (TXT_06_resultLeftArray);

		//reposition results 
		//if (currentQuestion == 0) {
			iTween.MoveTo (_result00, iTween.Hash ("x", _result00.GetComponent<RectTransform>().anchoredPosition.x -180F, "easetype", iTween.EaseType.easeInOutExpo, "time", 0F));
		//} else if (currentQuestion == 1) {
			iTween.MoveTo (_result01, iTween.Hash ("x", _result01.GetComponent<RectTransform>().anchoredPosition.x -180F, "easetype", iTween.EaseType.easeInOutExpo, "time", 0F));
		//} else if (currentQuestion == 2) {
			iTween.MoveTo (_result02, iTween.Hash ("x", _result02.GetComponent<RectTransform>().anchoredPosition.x -180F, "easetype", iTween.EaseType.easeInOutExpo, "time", 0F));
		//} else if (currentQuestion == 3) {
			iTween.MoveTo (_result03, iTween.Hash ("x", _result03.GetComponent<RectTransform>().anchoredPosition.x -180F, "easetype", iTween.EaseType.easeInOutExpo, "time", 0F));
		//} else if (currentQuestion == 4) {
			iTween.MoveTo (_result04, iTween.Hash ("x", _result04.GetComponent<RectTransform>().anchoredPosition.x -180F, "easetype", iTween.EaseType.easeInOutExpo, "time", 0F));
		//} else if (currentQuestion == 5) {
			iTween.MoveTo (_result05, iTween.Hash ("x", _result05.GetComponent<RectTransform>().anchoredPosition.x -180F, "easetype", iTween.EaseType.easeInOutExpo, "time", 0F));
		//} else {
			iTween.MoveTo (_result06, iTween.Hash ("x", _result06.GetComponent<RectTransform>().anchoredPosition.x -180F, "easetype", iTween.EaseType.easeInOutExpo, "time", 0F));
		//}
	}


	#endregion


	#region headlines animation

	public void moveStrategieIn() { 
		iTween.MoveTo (strategieTXT.gameObject, iTween.Hash ("x", strategieTXTstartPos, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
		BTN_strategieON.color = highlightedButtonColor;
		BTN_strategieOFF.color = standardButtonColor;
	}
	public void moveBauIn() { 
		iTween.MoveTo (bauTXT.gameObject, iTween.Hash ("x", bauTXTstartPos, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
		BTN_baufinanzON.color = highlightedButtonColor;
		BTN_baufinanzOFF.color = standardButtonColor;
	}
	public void moveDigiIn() { 
		iTween.MoveTo (digiTXT.gameObject, iTween.Hash ("x", digiTXTstartPos, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
		BTN_digiON.color = highlightedButtonColor;
		BTN_digiOFF.color = standardButtonColor;
	}
	public void moveVertriebIn() { 
		iTween.MoveTo (vertriebTXT.gameObject, iTween.Hash ("x", vertriebTXTstartPos, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
		BTN_vertriebON.color = highlightedButtonColor;
		BTN_vertriebOFF.color = standardButtonColor;
	}
	public void moveRoboterIn() { 
		iTween.MoveTo (roboterTXT.gameObject, iTween.Hash ("x", roboterTXTstartPos, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
		BTN_roboterON.color = highlightedButtonColor;
		BTN_roboterOFF.color = standardButtonColor;
	}


	public void moveStrategieOut() { 
		iTween.MoveTo (strategieTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
		BTN_strategieOFF.color = highlightedButtonColor;
		BTN_strategieON.color = standardButtonColor;
	}
	public void moveBauOut() { 
		iTween.MoveTo (bauTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
		BTN_baufinanzOFF.color = highlightedButtonColor;
		BTN_baufinanzON.color = standardButtonColor;
	}
	public void moveDigiOut() { 
		iTween.MoveTo (digiTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
		BTN_digiOFF.color = highlightedButtonColor;
		BTN_digiON.color = standardButtonColor;
	}
	public void moveVertriebOut() { 
		iTween.MoveTo (vertriebTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
		BTN_vertriebOFF.color = highlightedButtonColor;
		BTN_vertriebON.color = standardButtonColor;
	}
	public void moveRoboterOut() { 
		iTween.MoveTo (roboterTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
		BTN_roboterOFF.color = highlightedButtonColor;
		BTN_roboterON.color = standardButtonColor;
	}

	#endregion


	public void startCountdown() {
		BTNcountdown.color = standardButtonColor;
		BTNresults.color = highlightedButtonColorYellow;
	}



	#region results



	public void showResults() {

		BTNresults.color = standardButtonColor;
		BTNremove.color = highlightedButtonColorYellow;

		showedResults = true;

		string tmp = inputResult01.text;
		try{
		result01 = float.Parse (tmp);
		result01 = result01 / 100;

		tmp = inputResult02.text;
		result02 = float.Parse (tmp);
		result02 = result02 / 100;

		tmp = inputResult03.text;
		result03 = float.Parse (tmp);
		result03 = result03/ 100;
			/*
		tmp = inputResult04.text;
		result04 = float.Parse (tmp);
		result04 = result04 / 100;
		*/
		} catch(Exception e) {
			Debug.Log (e);
			resultError.text = "wrong input";
			return;
		}
		//check sum
		float sum = result01 + result02 + result03;

		if (sum == 1 || sum == 0) {
			resultError.text = "";

			if (sum == 0) {
				//resetCubesAnimated ();
			} else {

				//setFinalValues for SWING
				currentResultFloat =  (Math.Max(result01, Math.Max(result02, Math.Max(result03, 0F))));

				if (result01 == currentResultFloat) {
					Debug.Log ("ident");
					currentResultColor = 0;
					currentResultString = questions [currentQuestion, 1];
				} else if (result02 == currentResultFloat) {
					currentResultColor = 1;
					currentResultString = questions [currentQuestion, 2];
				} else if (result03 == currentResultFloat) {
					currentResultColor = 2;
					currentResultString = questions [currentQuestion, 3];
				} else {
					currentResultColor = 3;
					currentResultString = questions [currentQuestion, 4];
				}

				currentResultFloat *= 100F;





				if (currentQuestion == 0) {
					TXT_00_allresultArray [0].text = result01 * 100F + " %";
					TXT_00_allresultArray [1].text = result02 * 100F + " %";
					TXT_00_allresultArray [2].text = result03 * 100F + " %";
					fadeInResults (TXT_00_allresultArray);
					fadeColorToColor (TXT_00_resultLeftArray);

					//animate specific cube
					animateCubesOut(testCube2, testCube3, testCube4, testCube1startPosition.y);

				} else if (currentQuestion == 1) {
					TXT_01_allresultArray [0].text = result01 * 100F + " %";
					TXT_01_allresultArray [1].text = result02 * 100F + " %";
					TXT_01_allresultArray [2].text = result03 * 100F + " %";
					fadeInResults (TXT_01_allresultArray);
					fadeColorToColor (TXT_01_resultLeftArray);

					//animate specific cube
					animateCubesOut(cubeQ01_01, cubeQ01_02, cubeQ01_03, cubeQ01startPosition.y);

				} else if (currentQuestion == 2) {
					TXT_02_allresultArray [0].text = result01 * 100F + " %";
					TXT_02_allresultArray [1].text = result02 * 100F + " %";
					TXT_02_allresultArray [2].text = result03 * 100F + " %";
					fadeInResults (TXT_02_allresultArray);
					fadeColorToColor (TXT_02_resultLeftArray);

					//animate specific cube
					animateCubesOut(cubeQ02_01, cubeQ02_02, cubeQ02_03, cubeQ02startPosition.y);

				} else if (currentQuestion == 3) {
					TXT_03_allresultArray [0].text = result01 * 100F + " %";
					TXT_03_allresultArray [1].text = result02 * 100F + " %";
					TXT_03_allresultArray [2].text = result03 * 100F + " %";
					fadeInResults (TXT_03_allresultArray);
					fadeColorToColor (TXT_03_resultLeftArray);

					//animate specific cube
					animateCubesOut(cubeQ03_01, cubeQ03_02, cubeQ03_03, cubeQ03startPosition.y);

				} else if (currentQuestion == 4) {
					TXT_04_allresultArray [0].text = result01 * 100F + " %";
					TXT_04_allresultArray [1].text = result02 * 100F + " %";
					TXT_04_allresultArray [2].text = result03 * 100F + " %";
					fadeInResults (TXT_04_allresultArray);
					fadeColorToColor (TXT_04_resultLeftArray);

					//animate specific cube
					animateCubesOut(cubeQ04_01, cubeQ04_02, cubeQ04_03, cubeQ04startPosition.y);

				} else if (currentQuestion == 5) {
					TXT_05_allresultArray [0].text = result01 * 100F + " %";
					TXT_05_allresultArray [1].text = result02 * 100F + " %";
					TXT_05_allresultArray [2].text = result03 * 100F + " %";
					fadeInResults (TXT_05_allresultArray);
					fadeColorToColor (TXT_05_resultLeftArray);

					//animate specific cube
					animateCubesOut(cubeQ05_01, cubeQ05_02, cubeQ05_03, cubeQ05startPosition.y);

				} else if (currentQuestion == 6) {
					TXT_06_allresultArray [0].text = result01 * 100F + " %";
					TXT_06_allresultArray [1].text = result02 * 100F + " %";
					TXT_06_allresultArray [2].text = result03 * 100F + " %";
					fadeInResults (TXT_06_allresultArray);
					fadeColorToColor (TXT_06_resultLeftArray);

					//animate specific cube
					animateCubesOut(cubeQ06_01, cubeQ06_02, cubeQ06_03, cubeQ06startPosition.y);

				}  



			}

		} else {

			resultError.text = (100 - sum*100) + "% only";
		}
	}


	private void fadeInResults(Text[] txtArray) {
		txtArray[0].CrossFadeAlpha(1F, 0.5F, false);
		txtArray[1].CrossFadeAlpha(1F, 0.5F, false);
		txtArray[2].CrossFadeAlpha(1F, 0.5F, false);
	} 

	private void fadeOutResults(Text[] txtArray) {
		txtArray[0].CrossFadeAlpha(0F, 0F, false);
		txtArray[1].CrossFadeAlpha(0F, 0F, false);
		txtArray[2].CrossFadeAlpha(0F, 0F, false);
	} 

	private void fadeColorToColor(Text[] txtArray) {
		txtArray [0].CrossFadeColor (color01purple, 0.5F, false, false);
		txtArray [1].CrossFadeColor (color02blue, 0.5F, false, false);
		txtArray [2].CrossFadeColor (color03green, 0.5F, false, false);
	} 

	private void fadeColorToBlack(Text[] txtArray) {
		txtArray [0].CrossFadeColor (color00black, 0F, false, false);
		txtArray [1].CrossFadeColor (color00black, 0F, false, false);
		txtArray [2].CrossFadeColor (color00black, 0F, false, false);
	} 




	private void animateCubesOut(GameObject cube01, GameObject cube02, GameObject cube03, float startPos) { 

		//move result to tight
		//if (currentQuestion == 0) {
			iTween.MoveTo (_result00, iTween.Hash ("x", _result00.GetComponent<RectTransform>().anchoredPosition.x +180F, "easetype", iTween.EaseType.easeInOutExpo, "time", 1.5F));
		//} else if (currentQuestion == 1) {
			iTween.MoveTo (_result01, iTween.Hash ("x", _result01.GetComponent<RectTransform>().anchoredPosition.x +180F, "easetype", iTween.EaseType.easeInOutExpo, "time", 1.5F));
		//} else if (currentQuestion == 2) {
			iTween.MoveTo (_result02, iTween.Hash ("x", _result02.GetComponent<RectTransform>().anchoredPosition.x +180F, "easetype", iTween.EaseType.easeInOutExpo, "time", 1.5F));
		//} else if (currentQuestion == 3) {
			iTween.MoveTo (_result03, iTween.Hash ("x", _result03.GetComponent<RectTransform>().anchoredPosition.x +180F, "easetype", iTween.EaseType.easeInOutExpo, "time", 1.5F));
		//} else if (currentQuestion == 4) {
			iTween.MoveTo (_result04, iTween.Hash ("x", _result04.GetComponent<RectTransform>().anchoredPosition.x +180F, "easetype", iTween.EaseType.easeInOutExpo, "time", 1.5F));
		//} else if (currentQuestion == 5) {
			iTween.MoveTo (_result05, iTween.Hash ("x", _result05.GetComponent<RectTransform>().anchoredPosition.x +180F, "easetype", iTween.EaseType.easeInOutExpo, "time", 1.5F));
		//} else {
			iTween.MoveTo (_result06, iTween.Hash ("x", _result06.GetComponent<RectTransform>().anchoredPosition.x +180F, "easetype", iTween.EaseType.easeInOutExpo, "time", 1.5F));
		//}
			
		//CUBE ANIMATION
		iTween.MoveTo (cube03, iTween.Hash ("y", startPos + 0F * scaleIndex + result03 * scaleIndex + result02 * scaleIndex + spaceBetweenCubes * 2F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.MoveTo (cube02, iTween.Hash ("y", startPos + 0F * scaleIndex + result03 * scaleIndex + spaceBetweenCubes * 1F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.MoveTo (cube01, iTween.Hash ("y", startPos + 0F * scaleIndex + spaceBetweenCubes * 0F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		//iTween.MoveTo (testCube1, iTween.Hash ("y", testCube1startPosition.y, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));

		//iTween.ScaleTo (testCube1, iTween.Hash ("scale", new Vector3 (1F, result04, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.ScaleTo (cube01, iTween.Hash ("scale", new Vector3 (1F, result03, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.ScaleTo (cube02, iTween.Hash ("scale", new Vector3 (1F, result02, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0.5F));
		iTween.ScaleTo (cube03, iTween.Hash ("scale", new Vector3 (1F, result01, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 1F));
	}


	private void resetCubes(GameObject cube01, GameObject cube02, GameObject cube03, Vector3 startPos) { 
		//testCube1.transform.position = new Vector3 (testCube1startPosition.x, testCube1startPosition.y - 0.1F, testCube1startPosition.z);
		cube01.transform.position = new Vector3 (startPos.x, startPos.y - 0.1F, startPos.z);
		cube02.transform.position = new Vector3 (startPos.x, startPos.y - 0.1F, startPos.z);
		cube03.transform.position = new Vector3 (startPos.x, startPos.y - 0.1F, startPos.z);

		//testCube1.transform.localScale = new Vector3(1F, 0F, 1F);
		cube01.transform.localScale = new Vector3(1F, 0F, 1F);
		cube02.transform.localScale = new Vector3(1F, 0F, 1F);
		cube03.transform.localScale = new Vector3(1F, 0F, 1F);

	}

	private void resetCubesAnimated(GameObject cube01, GameObject cube02, GameObject cube03, Vector3 startPos) {
		
		//iTween.MoveTo (testCube1, iTween.Hash ("y", testCube1startPosition.y - 0.1F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.MoveTo (cube01, iTween.Hash ("y", startPos.y - 0.1F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.MoveTo (cube02, iTween.Hash ("y", startPos.y - 0.1F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.MoveTo (cube03, iTween.Hash ("y", startPos.y - 0.1F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));


		//iTween.ScaleTo (testCube1, iTween.Hash ("scale", new Vector3 (1F, 0F, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.ScaleTo (cube01, iTween.Hash ("scale", new Vector3 (1F, 0F, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.ScaleTo (cube02, iTween.Hash ("scale", new Vector3 (1F, 0F, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.ScaleTo (cube03, iTween.Hash ("scale", new Vector3 (1F, 0F, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
	
	}



	#endregion







	public void moveCamLeft() {
		iTween.MoveTo(mainCam3D, iTween.Hash("x", mainCam3D.transform.position.x - 3, "easetype", iTween.EaseType.easeInOutQuad, "time", 6F));
	}

	public void moveCamRight() {
		iTween.MoveTo(mainCam3D, iTween.Hash("x", mainCam3D.transform.position.x + 3, "easetype", iTween.EaseType.easeInOutQuad, "time", 6F));

	}

	public void moveCamTop() {
		iTween.MoveTo(mainCam3D, iTween.Hash("z", mainCam3D.transform.position.z + 3, "easetype", iTween.EaseType.easeInOutQuad, "time", 6F));

	}

	public void moveCamBottom() {
		iTween.MoveTo(mainCam3D, iTween.Hash("z", mainCam3D.transform.position.z - 3, "easetype", iTween.EaseType.easeInOutQuad, "time", 6F));

	}

	public void moveCamCenter() {
		iTween.MoveTo(mainCam3D, iTween.Hash("position", mainCam3DstartPos, "easetype", iTween.EaseType.easeInOutQuad, "time", 6F));

	}




}
