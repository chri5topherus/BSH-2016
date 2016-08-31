using UnityEngine;
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

	private Vector3 mainCam3DstartPos;

	[Header ("------ chapter headlines ------")]

	public Text strategieTXT;
	public Text bauTXT;
	public Text digiTXT;
	public Text vertriebTXT;

	private float strategieTXTstartPos;
	private float bauTXTstartPos;
	private float digiTXTstartPos;
	private float vertriebTXTstartPos;

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


	[Header ("------ phone off ------")]

	//bauchbinden 
	public Text phoneOff;
	private bool phoneOffVisible;



	[Header ("------ questions ------")]

	//fields for controll interface
	public InputField inputTextQuestion;
	public InputField inputTextAnswer01;
	public InputField inputTextAnswer02;
	public InputField inputTextAnswer03;
	public InputField inputTextAnswer04;

	public Text[] TXT_01_allresultArray = new Text[3];
	public Text[] TXT_02_allresultArray = new Text[3];
	public Text[] TXT_03_allresultArray = new Text[3];
	public Text[] TXT_04_allresultArray = new Text[3];
	public Text[] TXT_05_allresultArray = new Text[3];
	public Text[] TXT_06_allresultArray = new Text[3];



	// translation objects
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

	//questions array
	private int currentQuestion;

	[Header ("------ q counter ------")]

	public Text TXT_currentQuestion;
	private string [,] questions;



	[Header ("------ results ------")]

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

	[Header ("------ cube objects ------")]

	//objects

	private Vector3 testCube1startPosition;

	//public GameObject testCube1;
	public GameObject testCube2;
	public GameObject testCube3;
	public GameObject testCube4;



	// Use this for initialization
	void Start () {

		mainCam3DstartPos = new Vector3 (mainCam3D.transform.position.x, mainCam3D.transform.position.y, mainCam3D.transform.position.z);
		testCube1startPosition = testCube2.transform.position;

		// ---- PHONE OFF ----
		phoneOffVisible = false;
		phoneOff.CrossFadeAlpha (0F, 0F, false);

		// ---- HEADLINES ----
		strategieTXTstartPos = strategieTXT.GetComponent<RectTransform> ().anchoredPosition.x;
		bauTXTstartPos = bauTXT.GetComponent<RectTransform> ().anchoredPosition.x;
		digiTXTstartPos = digiTXT.GetComponent<RectTransform> ().anchoredPosition.x;
		vertriebTXTstartPos = vertriebTXT.GetComponent<RectTransform> ().anchoredPosition.x;

		// ---- HEADLINES OFF ----
		iTween.MoveTo (strategieTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", 0F));
		iTween.MoveTo (bauTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", 0F));
		iTween.MoveTo (digiTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", 0F));
		iTween.MoveTo (vertriebTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", 0F));

		// ---- BAUCHBINDEN ----
		bauchbindeStartPos = bauchbinde.transform.position.y;
		inputTextBauchbinde01.text = "Nova ";
		inputTextBauchbinde02.text = "Herr Hinterberger ";
		inputTextBauchbinde03.text = "Herr Klein";
		inputTextBauchbinde04.text = "Prof. Dr. Rieck";
		inputTextBauchbinde05.text = "Jochen Maier";
		inputTextBauchbinde06.text = "Sabine Baron";
		inputTextBauchbinde07.text = "Kristin Seyboth";
		inputTextBauchbinde08.text = "Schüttler";
		inputTextBauchbinde09.text = "Biermann";
		inputTextBauchbinde10.text = "empty";

		inputTextBauchbindeTitle01.text = "empty1";
		inputTextBauchbindeTitle02.text = "empty2";
		inputTextBauchbindeTitle03.text = "empty3";
		inputTextBauchbindeTitle04.text = "empty4";
		inputTextBauchbindeTitle05.text = "empty5";
		inputTextBauchbindeTitle06.text = "empty6";
		inputTextBauchbindeTitle07.text = "empty7";
		inputTextBauchbindeTitle08.text = "empty8";
		inputTextBauchbindeTitle09.text = "empty9";
		inputTextBauchbindeTitle10.text = "empty10";


		visibleBauchbinde = false;
		hideBauchbinde ();

		// ---- RESULTS ----
		fadeOutResults (TXT_01_allresultArray);
		fadeOutResults (TXT_02_allresultArray);
		fadeOutResults (TXT_03_allresultArray);
		fadeOutResults (TXT_04_allresultArray);
		fadeOutResults (TXT_05_allresultArray);
		fadeOutResults (TXT_06_allresultArray);

		TXT_currentQuestion.text = "1 / 6";

		spaceBetweenCubes = 0.2F;
		scaleIndex = 8.15f;

	
		// set question text
		questions = new string[,]{
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
		resetCubes ();
			

		// ----- QUESTION POSITION - NOT VISIBLE ------ 
		moveQuestionsInOut(_question01, _result01, false, 0F, 0F);	
		moveQuestionsInOut(_question02, _result02, false, 0F, 0F);	
		moveQuestionsInOut(_question03, _result03, false, 0F, 0F);	
		moveQuestionsInOut(_question04, _result04, false, 0F, 0F);	
		moveQuestionsInOut(_question05, _result05, false, 0F, 0F);	
		moveQuestionsInOut(_question06, _result06, false, 0F, 0F);	


		//camera setup
		mainCam3D01_startPos = mainCam3D01.transform.position.x;
		mainCam3D02_startPos = mainCam3D02.transform.position.x;
		mainCam3D03_startPos = mainCam3D03.transform.position.x;

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
		if (phoneOffVisible) 
			phoneOff.CrossFadeAlpha (0F, 1F, false);
		else 
			phoneOff.CrossFadeAlpha (1F, 1F, false);
		
		phoneOffVisible = !phoneOffVisible;
	}

	#endregion


	#region rebuild

	public void rebuildModus00() {
		string tmp = rebuildTime.text; 
		float durationTmp;
		try{
			durationTmp = float.Parse (tmp);
			iTween.MoveTo(mainCam3D01, iTween.Hash("x",  mainCam3D01_startPos, "time", durationTmp, "easetype", iTween.EaseType.linear));
			iTween.MoveTo(mainCam3D02, iTween.Hash("x",  mainCam3D02_startPos, "time", durationTmp, "easetype", iTween.EaseType.linear));
			iTween.MoveTo(mainCam3D03, iTween.Hash("x",  mainCam3D03_startPos, "time", durationTmp, "easetype", iTween.EaseType.linear));
		} catch(Exception e) { 
			Debug.Log (e);
		}

	}

	public void rebuildModus01() {
		string tmp = rebuildTime.text; 
		float durationTmp;
		float distanceTmp;
		try{
			durationTmp = float.Parse (tmp);
			string tmp2 = rebuildDistance.text; 
			distanceTmp = float.Parse (tmp2);
		distanceTmp = distanceTmp / 100f;
			iTween.MoveTo(mainCam3D01, iTween.Hash("x",  mainCam3D01_startPos - distanceTmp/2F, "time", durationTmp, "easetype", iTween.EaseType.linear));
			iTween.MoveTo(mainCam3D02, iTween.Hash("x",  mainCam3D02_startPos + distanceTmp/2F, "time", durationTmp, "easetype", iTween.EaseType.linear));
			iTween.MoveTo(mainCam3D03, iTween.Hash("x",  mainCam3D03_startPos + distanceTmp/2F, "time", durationTmp, "easetype", iTween.EaseType.linear));
		} catch(Exception e) {
			Debug.Log (e);
		}

	}

	public void rebuildModus02() {
		string tmp = rebuildTime.text; 
		float durationTmp;
		float distanceTmp;
		try {
			durationTmp = float.Parse (tmp);
			string tmp2 = rebuildDistance.text; 
			distanceTmp = float.Parse (tmp2);
			distanceTmp = distanceTmp / 100f;
			iTween.MoveTo(mainCam3D01, iTween.Hash("x",  mainCam3D01_startPos - distanceTmp/2F, "time", durationTmp, "easetype", iTween.EaseType.linear));
			iTween.MoveTo(mainCam3D02, iTween.Hash("x",  mainCam3D02_startPos, "time", durationTmp, "easetype", iTween.EaseType.linear));
			iTween.MoveTo(mainCam3D03, iTween.Hash("x",  mainCam3D03_startPos + distanceTmp/2F, "time", durationTmp, "easetype", iTween.EaseType.linear));
		} catch(Exception e) { 
			Debug.Log (e);
		}

	}

	#endregion


	#region bauchbinde

	public void showBauchbinde01() {
		if (!visibleBauchbinde) {
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde01.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle01.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde02() {
		if (!visibleBauchbinde) {
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde02.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle02.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde03() {
		if (!visibleBauchbinde) {
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde03.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle03.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde04() {
		if (!visibleBauchbinde) {
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde04.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle04.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde05() {
		if (!visibleBauchbinde) {
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde05.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle05.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde06() {
		if (!visibleBauchbinde) {
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde06.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle06.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde07() {
		if (!visibleBauchbinde) {
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde07.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle07.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde08() {
		if (!visibleBauchbinde) {
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde08.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle08.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde09() {
		if (!visibleBauchbinde) {
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde09.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle09.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void showBauchbinde10() {
		if (!visibleBauchbinde) {
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde10.text;
			TXT_bauchbinde02.text = inputTextBauchbindeTitle10.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", bauchbindeStartPos, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void hideBauchbinde() {
		visibleBauchbinde = false;
		iTween.MoveTo(bauchbinde, iTween.Hash("y", 500F , "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
	}

	#endregion


	#region question

	public void showQuestion() {
		float delayTmp = 1F;
		if (currentQuestion == 0) {
			moveQuestionsInOut (_question01, _result01, true, 2F, delayTmp);
		} else if (currentQuestion == 1) {
			moveQuestionsInOut (_question02, _result02, true, 2F, delayTmp);
		} else if (currentQuestion == 2) {
			moveQuestionsInOut (_question03, _result03, true, 2F, delayTmp);
		} else if (currentQuestion == 3) {
			moveQuestionsInOut (_question04, _result04, true, 2F, delayTmp);
		} else if (currentQuestion == 4) {
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
		if (currentQuestion < 5) {
			currentQuestion++;
			TXT_currentQuestion.text = (currentQuestion+1) + " / 6";
			refreshQuestion ();
		}
	}
		
	public void showPreviousQuestion() {
		if (currentQuestion > 0) {
			currentQuestion--;
			TXT_currentQuestion.text = (currentQuestion+1) + " / 6";
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
		float delayTmp = 0F;
		if (currentQuestion == 0) {
			moveQuestionsInOut (_question01, _result01, false, 2F, delayTmp);
		} else if (currentQuestion == 1) {
			moveQuestionsInOut (_question02, _result02, false, 2F, delayTmp);
		} else if (currentQuestion == 2) {
			moveQuestionsInOut (_question03, _result03, false, 2F, delayTmp);
		} else if (currentQuestion == 3) {
			moveQuestionsInOut (_question04, _result04, false, 2F, delayTmp);
		} else if (currentQuestion == 4) {
			moveQuestionsInOut (_question05, _result05, false, 2F, delayTmp);
		} else {
			moveQuestionsInOut (_question06, _result06, false, 2F, delayTmp);
		}
		resultError.text = "";
		resetCubesAnimated ();
	}


	#endregion


	#region headlines animation

	public void moveStrategieIn() { 
		iTween.MoveTo (strategieTXT.gameObject, iTween.Hash ("x", strategieTXTstartPos, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
	}
	public void moveBauIn() { 
		iTween.MoveTo (bauTXT.gameObject, iTween.Hash ("x", bauTXTstartPos, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
	}
	public void moveDigiIn() { 
		iTween.MoveTo (digiTXT.gameObject, iTween.Hash ("x", digiTXTstartPos, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
	}
	public void moveVertriebIn() { 
		iTween.MoveTo (vertriebTXT.gameObject, iTween.Hash ("x", vertriebTXTstartPos, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
	}



	public void moveStrategieOut() { 
		iTween.MoveTo (strategieTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
	}
	public void moveBauOut() { 
		iTween.MoveTo (bauTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
	}
	public void moveDigiOut() { 
		iTween.MoveTo (digiTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
	}
	public void moveVertriebOut() { 
		iTween.MoveTo (vertriebTXT.gameObject, iTween.Hash ("x", -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", animationDuration));
	}

	#endregion


	#region results



	public void displayResults() {
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
					TXT_01_allresultArray [0].text = result01 * 100F + " %";
					TXT_01_allresultArray [1].text = result02 * 100F + " %";
					TXT_01_allresultArray [2].text = result03 * 100F + " %";
					fadeInResults (TXT_01_allresultArray);

					//TODO
					//animate specific cube

				} else if (currentQuestion == 1) {
					TXT_02_allresultArray [0].text = result01 * 100F + " %";
					TXT_02_allresultArray [1].text = result02 * 100F + " %";
					TXT_02_allresultArray [2].text = result03 * 100F + " %";
					fadeInResults (TXT_02_allresultArray);

					//TODO
					//animate specific cube

				} else if (currentQuestion == 2) {
					TXT_03_allresultArray [0].text = result01 * 100F + " %";
					TXT_03_allresultArray [1].text = result02 * 100F + " %";
					TXT_03_allresultArray [2].text = result03 * 100F + " %";
					fadeInResults (TXT_03_allresultArray);

					//TODO
					//animate specific cube

				} else if (currentQuestion == 3) {
					TXT_04_allresultArray [0].text = result01 * 100F + " %";
					TXT_04_allresultArray [1].text = result02 * 100F + " %";
					TXT_04_allresultArray [2].text = result03 * 100F + " %";
					fadeInResults (TXT_04_allresultArray);

					//TODO
					//animate specific cube

				} else if (currentQuestion == 4) {
					TXT_05_allresultArray [0].text = result01 * 100F + " %";
					TXT_05_allresultArray [1].text = result02 * 100F + " %";
					TXT_05_allresultArray [2].text = result03 * 100F + " %";
					fadeInResults (TXT_05_allresultArray);

					//TODO
					//animate specific cube

				} else if (currentQuestion == 5) {
					TXT_06_allresultArray [0].text = result01 * 100F + " %";
					TXT_06_allresultArray [1].text = result02 * 100F + " %";
					TXT_06_allresultArray [2].text = result03 * 100F + " %";
					fadeInResults (TXT_06_allresultArray);

					//TODO
					//animate specific cube

				}


				//CUBE ANIMATION
				iTween.MoveTo (testCube4, iTween.Hash ("y", testCube1startPosition.y + 0F * scaleIndex + result03 * scaleIndex + result02 * scaleIndex + spaceBetweenCubes * 2F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
				iTween.MoveTo (testCube3, iTween.Hash ("y", testCube1startPosition.y + 0F * scaleIndex + result03 * scaleIndex + spaceBetweenCubes * 1F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
				iTween.MoveTo (testCube2, iTween.Hash ("y", testCube1startPosition.y + 0F * scaleIndex + spaceBetweenCubes * 0F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
				//iTween.MoveTo (testCube1, iTween.Hash ("y", testCube1startPosition.y, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));

				//iTween.ScaleTo (testCube1, iTween.Hash ("scale", new Vector3 (1F, result04, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
				iTween.ScaleTo (testCube2, iTween.Hash ("scale", new Vector3 (1F, result03, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
				iTween.ScaleTo (testCube3, iTween.Hash ("scale", new Vector3 (1F, result02, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0.5F));
				iTween.ScaleTo (testCube4, iTween.Hash ("scale", new Vector3 (1F, result01, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 1F));
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


	private void resetCubes() { 
		//testCube1.transform.position = new Vector3 (testCube1startPosition.x, testCube1startPosition.y - 0.1F, testCube1startPosition.z);
		testCube2.transform.position = new Vector3 (testCube1startPosition.x, testCube1startPosition.y - 0.1F, testCube1startPosition.z);
		testCube3.transform.position = new Vector3 (testCube1startPosition.x, testCube1startPosition.y - 0.1F, testCube1startPosition.z);
		testCube4.transform.position = new Vector3 (testCube1startPosition.x, testCube1startPosition.y - 0.1F, testCube1startPosition.z);

		//testCube1.transform.localScale = new Vector3(1F, 0F, 1F);
		testCube2.transform.localScale = new Vector3(1F, 0F, 1F);
		testCube3.transform.localScale = new Vector3(1F, 0F, 1F);
		testCube4.transform.localScale = new Vector3(1F, 0F, 1F);

	}

	private void resetCubesAnimated() {
		
		//iTween.MoveTo (testCube1, iTween.Hash ("y", testCube1startPosition.y - 0.1F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.MoveTo (testCube2, iTween.Hash ("y", testCube1startPosition.y - 0.1F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.MoveTo (testCube3, iTween.Hash ("y", testCube1startPosition.y - 0.1F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.MoveTo (testCube4, iTween.Hash ("y", testCube1startPosition.y - 0.1F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));


		//iTween.ScaleTo (testCube1, iTween.Hash ("scale", new Vector3 (1F, 0F, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.ScaleTo (testCube2, iTween.Hash ("scale", new Vector3 (1F, 0F, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.ScaleTo (testCube3, iTween.Hash ("scale", new Vector3 (1F, 0F, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.ScaleTo (testCube4, iTween.Hash ("scale", new Vector3 (1F, 0F, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
	
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
