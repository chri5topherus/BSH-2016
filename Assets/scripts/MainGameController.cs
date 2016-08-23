using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class MainGameController : MonoBehaviour {


	[Header ("------ camera objects ------")]

	public GameObject mainCam2D; 
	public GameObject mainCam3D;
	private Vector3 mainCam3DstartPos;

	[Header ("------ bauchbinde ------")]

	//bauchbinden 
	public InputField inputTextBauchbinde01;
	public InputField inputTextBauchbinde02;
	public Text TXT_bauchbinde01;
	public GameObject bauchbinde;
	private bool visibleBauchbinde;

	[Header ("------ questions ------")]

	//questions
	public InputField inputTextQuestion;
	public InputField inputTextAnswer01;
	public InputField inputTextAnswer02;
	public InputField inputTextAnswer03;
	public InputField inputTextAnswer04;
	public Text TXT_question; 
	public Text TXT_answer01; 
	public Text TXT_answer02; 
	public Text TXT_answer03; 
	public Text TXT_answer04; 

	public GameObject questionsGO;


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
	private float result04; 

	public InputField inputResult01;
	public InputField inputResult02;
	public InputField inputResult03;
	public InputField inputResult04;

	[Header ("------ objects ------")]

	//objects

	private Vector3 testCube1startPosition;

	public GameObject testCube1;
	public GameObject testCube2;
	public GameObject testCube3;
	public GameObject testCube4;



	// Use this for initialization
	void Start () {

		mainCam3DstartPos = new Vector3 (mainCam3D.transform.position.x, mainCam3D.transform.position.y, mainCam3D.transform.position.z);
		testCube1startPosition = testCube1.transform.position;


		// ---- BAUCHBINDEN ----

		inputTextBauchbinde01.text = TXT_bauchbinde01.text;
		visibleBauchbinde = false;
		hideBauchbinde ();

		TXT_currentQuestion.text = "1 / 3";



		// ----- QUESTION ------

		currentQuestion = 0;

		//set question text
		questions = new string[,]{
			{ "Sind Sie gut durch den Verkehr gekommen?", "Bestens", "Ganz gut", "Ging so", "Eher schlecht als recht" }, 
			{ "...", "...", "...", "...", "..." }, 
			{ "...", "...", "...", "...", "..." }
		};

		//set first question in input fields
		refreshQuestion ();
		//hideQuestion ();
		resetCubes ();
	}
	
	// Update is called once per frame
	void Update () {
	
		/*
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Debug.Log ("up");
			StartCoroutine (startAnimation ());
			iTween.MoveTo (mainCam3D, iTween.Hash ("position", new Vector3 (mainCam3D.transform.position.x + 1, mainCam3D.transform.position.y, mainCam3D.transform.transform.position.z), "easetype", iTween.EaseType.easeInOutExpo, "time", 1F));
		}
*/
			
	}



	public void moveCam01() {
		iTween.MoveTo(mainCam3D, iTween.Hash("x",  -5F, "easetype", iTween.EaseType.easeInOutExpo, "time", 6F));

	}



	#region bauchbinde

	public void showBauchbinde01() {
		if (!visibleBauchbinde) {
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde01.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", -300F, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}


	public void showBauchbinde02() {
		if (!visibleBauchbinde) {
			visibleBauchbinde = true;
			TXT_bauchbinde01.text = inputTextBauchbinde02.text;
			iTween.MoveTo (bauchbinde, iTween.Hash ("y", -300F, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
		}
	}

	public void hideBauchbinde() {
		visibleBauchbinde = false;
		iTween.MoveTo(bauchbinde, iTween.Hash("y", -500F, "easetype", iTween.EaseType.easeInOutCubic, "time", 2F));
	}

	#endregion


	#region question

	public void showQuestion() {
		TXT_question.text = inputTextQuestion.text;
		TXT_answer01.text = inputTextAnswer01.text;
		TXT_answer02.text = inputTextAnswer02.text;
		TXT_answer03.text = inputTextAnswer03.text;
		TXT_answer04.text = inputTextAnswer04.text;

		questionsGO.SetActive (true);

	}

	public void hideQuestion() {
		questionsGO.SetActive (false);

	}



	private void refreshQuestion() {
		inputTextQuestion.text = questions[currentQuestion,0];
		inputTextAnswer01.text = questions[currentQuestion,1];
		inputTextAnswer02.text = questions[currentQuestion,2];
		inputTextAnswer03.text = questions[currentQuestion,3];
		inputTextAnswer04.text = questions[currentQuestion,4];

	}



	public void showNextQuestion() {
		if (currentQuestion < 2) {
			currentQuestion++;
			TXT_currentQuestion.text = (currentQuestion+1) + " / 3";
			refreshQuestion ();
		}
	}
		
	public void showPreviousQuestion() {
		if (currentQuestion > 0) {
			currentQuestion--;
			TXT_currentQuestion.text = (currentQuestion+1) + " / 3";
			refreshQuestion ();
		}
	}
		
	#endregion







	#region results



	public void displayResults() {
		string tmp = inputResult01.text;
		try{
		result04 = float.Parse (tmp);
		result04 = result04 / 100;

		tmp = inputResult02.text;
		result03 = float.Parse (tmp);
		result03 = result03 / 100;

		tmp = inputResult03.text;
		result02 = float.Parse (tmp);
		result02 = result02 / 100;

		tmp = inputResult04.text;
		result01 = float.Parse (tmp);
		result01 = result01 / 100;
		} catch(Exception e) {
			resultError.text = "wrong input";
			return;
		}
		//check sum
		float sum = result01 + result02 + result03 + result04;

		if (sum == 1 || sum == 0) {
			resultError.text = "";

			float spaceBetweenCubes = 0.1F;
			float scaleIndex = 2f;

			if (sum == 0)
				resetCubesAnimation ();
			else {

				//add percentage to answers
				TXT_answer01.text = inputTextAnswer01.text + "   " + result04*100 + " %";
				TXT_answer02.text = inputTextAnswer02.text + "   " + result03*100 + " %";
				TXT_answer03.text = inputTextAnswer03.text + "   " + result02*100 + " %";
				TXT_answer04.text = inputTextAnswer04.text + "   " + result01*100 + " %";


				iTween.MoveTo (testCube1, iTween.Hash ("y", testCube1startPosition.y, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
				iTween.MoveTo (testCube2, iTween.Hash ("y", testCube1startPosition.y + result01 * scaleIndex + spaceBetweenCubes * 1F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
				iTween.MoveTo (testCube3, iTween.Hash ("y", testCube1startPosition.y + result01 * scaleIndex + result02 * scaleIndex + spaceBetweenCubes * 2F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
				iTween.MoveTo (testCube4, iTween.Hash ("y", testCube1startPosition.y + result01 * scaleIndex + result02 * scaleIndex + result03 * scaleIndex + spaceBetweenCubes * 3F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));

				iTween.ScaleTo (testCube1, iTween.Hash ("scale", new Vector3 (1F, result01, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
				iTween.ScaleTo (testCube2, iTween.Hash ("scale", new Vector3 (1F, result02, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0.5F));
				iTween.ScaleTo (testCube3, iTween.Hash ("scale", new Vector3 (1F, result03, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 1F));
				iTween.ScaleTo (testCube4, iTween.Hash ("scale", new Vector3 (1F, result04, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 1.5F));
			}


		} else {
			//resultError.text = "not 100% -> " + (100 - sum*100) + " missing";
			resultError.text = "not 100%";
		}
	}
		
	public void clearResults() {
		resultError.text = "";
		showQuestion ();
		resetCubesAnimation ();
	}

	private void resetCubes() { 
		testCube1.transform.position = new Vector3 (testCube1startPosition.x, testCube1startPosition.y - 0.1F, testCube1startPosition.z);
		testCube2.transform.position = new Vector3 (testCube1startPosition.x, testCube1startPosition.y - 0.1F, testCube1startPosition.z);
		testCube3.transform.position = new Vector3 (testCube1startPosition.x, testCube1startPosition.y - 0.1F, testCube1startPosition.z);
		testCube4.transform.position = new Vector3 (testCube1startPosition.x, testCube1startPosition.y - 0.1F, testCube1startPosition.z);

		testCube1.transform.localScale = new Vector3(1F, 0F, 1F);
		testCube2.transform.localScale = new Vector3(1F, 0F, 1F);
		testCube3.transform.localScale = new Vector3(1F, 0F, 1F);
		testCube4.transform.localScale = new Vector3(1F, 0F, 1F);

	}

	private void resetCubesAnimation() {
		
		iTween.MoveTo (testCube1, iTween.Hash ("y", testCube1startPosition.y - 0.1F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.MoveTo (testCube2, iTween.Hash ("y", testCube1startPosition.y - 0.1F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.MoveTo (testCube3, iTween.Hash ("y", testCube1startPosition.y - 0.1F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
		iTween.MoveTo (testCube4, iTween.Hash ("y", testCube1startPosition.y - 0.1F, "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));


		iTween.ScaleTo (testCube1, iTween.Hash ("scale", new Vector3 (1F, 0F, 1F), "easetype", iTween.EaseType.easeInOutExpo, "time", 2F, "delay", 0F));
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
