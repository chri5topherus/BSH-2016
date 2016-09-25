using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BackgroundPauseAnimation : MonoBehaviour {

	public GameObject img01; 
	public GameObject img02; 
	public GameObject img03; 
	public GameObject img04; 
	public GameObject img05; 
	public GameObject img06; 
	public GameObject img07; 
	public GameObject img08; 
	public GameObject img09; 

	public float waitFor; 
	public float duration;

	public bool runningForward; 
	public bool runningReversed;
	public bool stopingAnimation;

	public Image button01;
	public Image button02;
	public Image button03;

	public Color standardColor; 
	public Color highlightedColor;

	public Image BTN_startingAnimation; 
	public Image BTN_endingAnimation; 
	public Image BTN_stopedAnimtion;

	// Use this for initialization
	void Start () {


		// timingCombis: 
		// waitFor: 0.5 & duration 4
		// waitFor: 1 & duration 8
		// waitFor: 2 & duration 16

		setSpeedMode02 ();
		BTN_stopedAnimtion.color = highlightedColor;

		setAllScale (0F);

		runningForward = false; 
		runningReversed = false; 
		stopingAnimation = false;

	}

	public void setSpeedMode01() {
		button01.color = highlightedColor;
		button02.color = standardColor;
		button03.color = standardColor;

		waitFor = 2F;
		duration = 16F;
	}
		
	public void setSpeedMode02() {
		button01.color = standardColor; 
		button02.color = highlightedColor; 
		button03.color = standardColor; 
		waitFor = 1f;
		duration = 8F;
	}

	public void setSpeedMode03() {
		button01.color = standardColor; 
		button02.color = standardColor; 
		button03.color = highlightedColor;
		waitFor = 0.5f;
		duration = 4F;
	}


	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartAnimation() {

		BTN_startingAnimation.color = highlightedColor; 
		BTN_endingAnimation.color = standardColor; 
		BTN_stopedAnimtion.color = standardColor;

		setAllScale (0F);
		runningForward = true;
		runningReversed = false;
		stopingAnimation = false;
		StartCoroutine (animationImg01 ());
	}

	public void StartReversedAnimation() {

		BTN_startingAnimation.color = standardColor; 
		BTN_endingAnimation.color = highlightedColor; 
		BTN_stopedAnimtion.color = standardColor;
		
		runningForward = false;
		runningReversed = true;
		stopingAnimation = false;
		sortAllLayers (); 
		setAllScale (1F);
		StartCoroutine (animationReversedImg01 ());
	}

	public void StopAnimation() {

		BTN_startingAnimation.color = standardColor; 
		BTN_endingAnimation.color = standardColor; 
		BTN_stopedAnimtion.color = highlightedColor;

		stopingAnimation = true;
	}

	private void sortAllLayers() {
		img09.GetComponent<RectTransform> ().SetAsLastSibling ();
		img08.GetComponent<RectTransform> ().SetAsLastSibling ();
		img07.GetComponent<RectTransform> ().SetAsLastSibling ();
		img06.GetComponent<RectTransform> ().SetAsLastSibling ();
		img05.GetComponent<RectTransform> ().SetAsLastSibling ();
		img04.GetComponent<RectTransform> ().SetAsLastSibling ();
		img03.GetComponent<RectTransform> ().SetAsLastSibling ();
		img02.GetComponent<RectTransform> ().SetAsLastSibling ();
		img01.GetComponent<RectTransform> ().SetAsLastSibling ();
	}

	IEnumerator sendImgBack(GameObject img, float wait) { 
		yield return new WaitForSeconds (wait);
		img.GetComponent<RectTransform> ().SetAsFirstSibling ();
	}



	IEnumerator animationReversedImg01() { 
		yield return new WaitForSeconds (waitFor);
		img01.GetComponent<RectTransform>().localScale = new Vector3(1F, 1F, 1F); 
		iTween.ScaleTo (img01, iTween.Hash ("x", 0F,  "time", duration, "easetype", iTween.EaseType.linear));
		StartCoroutine (sendImgBack (img01, duration));
		if(runningReversed)
			StartCoroutine (animationReversedImg02 ());	
	}



	IEnumerator animationReversedImg02() { 
		yield return new WaitForSeconds (waitFor);
		img02.GetComponent<RectTransform>().localScale = new Vector3(1F, 1F, 1F); 
		iTween.ScaleTo (img02, iTween.Hash ("x", 0F,  "time", duration, "easetype", iTween.EaseType.linear));
		StartCoroutine (sendImgBack (img02, duration));
		if(runningReversed)
			StartCoroutine (animationReversedImg03 ());	
	}

	IEnumerator animationReversedImg03() { 
		yield return new WaitForSeconds (waitFor);
		img03.GetComponent<RectTransform>().localScale = new Vector3(1F, 1F, 1F); 
		iTween.ScaleTo (img03, iTween.Hash ("x", 0F,  "time", duration, "easetype", iTween.EaseType.linear));
		StartCoroutine (sendImgBack (img03, duration));
		if(runningReversed)
			StartCoroutine (animationReversedImg04 ());	
	}

	IEnumerator animationReversedImg04() { 
		yield return new WaitForSeconds (waitFor);
		img04.GetComponent<RectTransform>().localScale = new Vector3(1F, 1F, 1F); 
		iTween.ScaleTo (img04, iTween.Hash ("x", 0F,  "time", duration, "easetype", iTween.EaseType.linear));
		StartCoroutine (sendImgBack (img04, duration));
		if(runningReversed)
			StartCoroutine (animationReversedImg05 ());	
	}

	IEnumerator animationReversedImg05() { 
		yield return new WaitForSeconds (waitFor);
		img05.GetComponent<RectTransform>().localScale = new Vector3(1F, 1F, 1F); 
		iTween.ScaleTo (img05, iTween.Hash ("x", 0F,  "time", duration, "easetype", iTween.EaseType.linear));
		StartCoroutine (sendImgBack (img05, duration));
		if(runningReversed)
			StartCoroutine (animationReversedImg06 ());	
	}

	IEnumerator animationReversedImg06() { 
		yield return new WaitForSeconds (waitFor);
		img06.GetComponent<RectTransform>().localScale = new Vector3(1F, 1F, 1F); 
		iTween.ScaleTo (img06, iTween.Hash ("x", 0F,  "time", duration, "easetype", iTween.EaseType.linear));
		StartCoroutine (sendImgBack (img06, duration));
		if(runningReversed)
			StartCoroutine (animationReversedImg07 ());	
	}

	IEnumerator animationReversedImg07() { 
		yield return new WaitForSeconds (waitFor);
		img07.GetComponent<RectTransform>().localScale = new Vector3(1F, 1F, 1F); 
		iTween.ScaleTo (img07, iTween.Hash ("x", 0F,  "time", duration, "easetype", iTween.EaseType.linear));
		StartCoroutine (sendImgBack (img07, duration));
		if(runningReversed)
			StartCoroutine (animationReversedImg08 ());	
	}

	IEnumerator animationReversedImg08() { 
		yield return new WaitForSeconds (waitFor);
		img08.GetComponent<RectTransform>().localScale = new Vector3(1F, 1F, 1F); 
		iTween.ScaleTo (img08, iTween.Hash ("x", 0F,  "time", duration, "easetype", iTween.EaseType.linear));
		StartCoroutine (sendImgBack (img08, duration));
		if(runningReversed)
			StartCoroutine (animationReversedImg09 ());	
	}

	IEnumerator animationReversedImg09() { 
		yield return new WaitForSeconds (waitFor);
		img09.GetComponent<RectTransform>().localScale = new Vector3(1F, 1F, 1F); 
		iTween.ScaleTo (img09, iTween.Hash ("x", 0F,  "time", duration, "easetype", iTween.EaseType.linear));
		StartCoroutine (sendImgBack (img09, duration));
		if (runningReversed) {
			if(!stopingAnimation)
				StartCoroutine (animationReversedImg01 ());	
		}
	}






	IEnumerator animationImg01() { 
		yield return new WaitForSeconds (waitFor);
		img01.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
		img01.GetComponent<RectTransform> ().SetAsLastSibling ();
		iTween.ScaleTo (img01, iTween.Hash ("x", 1F,  "time", duration, "easetype", iTween.EaseType.linear));
		if(runningForward)
		StartCoroutine (animationImg02 ());	
	}

	IEnumerator animationImg02() { 
		yield return new WaitForSeconds (waitFor);
		img02.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
		img02.GetComponent<RectTransform> ().SetAsLastSibling ();
		iTween.ScaleTo (img02, iTween.Hash ("x", 1F,  "time", duration, "easetype", iTween.EaseType.linear));
		if(runningForward)
		StartCoroutine (animationImg03 ());	
	}

	IEnumerator animationImg03() { 
		yield return new WaitForSeconds (waitFor);
		img03.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
		img03.GetComponent<RectTransform> ().SetAsLastSibling ();
		iTween.ScaleTo (img03, iTween.Hash ("x", 1F,  "time", duration, "easetype", iTween.EaseType.linear));
		if(runningForward)
		StartCoroutine (animationImg04 ());	
	}

	IEnumerator animationImg04() { 
		yield return new WaitForSeconds (waitFor);
		img04.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
		img04.GetComponent<RectTransform> ().SetAsLastSibling ();
		iTween.ScaleTo (img04, iTween.Hash ("x", 1F,  "time", duration, "easetype", iTween.EaseType.linear));
		if(runningForward)
		StartCoroutine (animationImg05 ());	
	}

	IEnumerator animationImg05() { 
		yield return new WaitForSeconds (waitFor);
		img05.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
		img05.GetComponent<RectTransform> ().SetAsLastSibling ();
		iTween.ScaleTo (img05, iTween.Hash ("x", 1F,  "time", duration, "easetype", iTween.EaseType.linear));
		if(runningForward)
		StartCoroutine (animationImg06 ());	
	}

	IEnumerator animationImg06() { 
		yield return new WaitForSeconds (waitFor);
		img06.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
		img06.GetComponent<RectTransform> ().SetAsLastSibling ();
		iTween.ScaleTo (img06, iTween.Hash ("x", 1F,  "time", duration, "easetype", iTween.EaseType.linear));
		if(runningForward)
		StartCoroutine (animationImg07 ());	
	}

	IEnumerator animationImg07() { 
		yield return new WaitForSeconds (waitFor);
		img07.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
		img07.GetComponent<RectTransform> ().SetAsLastSibling ();
		iTween.ScaleTo (img07, iTween.Hash ("x", 1F,  "time", duration, "easetype", iTween.EaseType.linear));
		if(runningForward)
		StartCoroutine (animationImg08 ());	
	}

	IEnumerator animationImg08() { 
		yield return new WaitForSeconds (waitFor);
		img08.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
		img08.GetComponent<RectTransform> ().SetAsLastSibling ();
		iTween.ScaleTo (img08, iTween.Hash ("x", 1F,  "time", duration, "easetype", iTween.EaseType.linear));
		if(runningForward)
		StartCoroutine (animationImg09 ());	
	}

	IEnumerator animationImg09() { 
		yield return new WaitForSeconds (waitFor);
		img09.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
		img09.GetComponent<RectTransform> ().SetAsLastSibling ();
		iTween.ScaleTo (img09, iTween.Hash ("x", 1F,  "time", duration, "easetype", iTween.EaseType.linear));
		if(runningForward)
		StartCoroutine (animationImg01 ());	
	}





	IEnumerator changeOrder(float wait, GameObject obj) {
		yield return new WaitForSeconds (wait);
		obj.GetComponent<RectTransform> ().SetAsLastSibling ();
		obj.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
	}


	void setAllScale(float x) {
		img01.GetComponent<RectTransform>().localScale = new Vector3(x, 1F, 1F); 
		img02.GetComponent<RectTransform>().localScale = new Vector3(x, 1F, 1F); 
		img03.GetComponent<RectTransform>().localScale = new Vector3(x, 1F, 1F); 
		img04.GetComponent<RectTransform>().localScale = new Vector3(x, 1F, 1F); 
		img05.GetComponent<RectTransform>().localScale = new Vector3(x, 1F, 1F); 
		img06.GetComponent<RectTransform>().localScale = new Vector3(x, 1F, 1F); 
		img07.GetComponent<RectTransform>().localScale = new Vector3(x, 1F, 1F); 
		img08.GetComponent<RectTransform>().localScale = new Vector3(x, 1F, 1F); 
		img09.GetComponent<RectTransform>().localScale = new Vector3(x, 1F, 1F); 
	}



}
