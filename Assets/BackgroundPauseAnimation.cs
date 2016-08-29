using UnityEngine;
using System.Collections;

public class BackgroundPauseAnimation : MonoBehaviour {

	public GameObject img01; 
	public GameObject img02; 
	public GameObject img03; 
	public GameObject img04; 
	public GameObject img05; 
	public GameObject img06; 
	public GameObject img07; 
	public GameObject img08; 

	// Use this for initialization
	void Start () {

		setAllScaleZero ();

		startAnimation ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void startAnimation() {

		//for (int i = 0; i < 30; i++) {
		iTween.ScaleTo (img01, iTween.Hash ("x", 1F,  "time", 4F, "delay", 0F, "easetype", iTween.EaseType.linear));
		iTween.ScaleTo (img02, iTween.Hash ("x", 1F,  "time", 4F, "delay", 0.5F, "easetype", iTween.EaseType.linear));
		iTween.ScaleTo (img03, iTween.Hash ("x", 1F,  "time", 4F, "delay", 1F, "easetype", iTween.EaseType.linear));
		iTween.ScaleTo (img04, iTween.Hash ("x", 1F,  "time", 4F, "delay", 1.5F, "easetype", iTween.EaseType.linear));
		iTween.ScaleTo (img05, iTween.Hash ("x", 1F,  "time", 4F, "delay", 2F, "easetype", iTween.EaseType.linear));
		iTween.ScaleTo (img06, iTween.Hash ("x", 1F,  "time", 4F, "delay", 2.5F, "easetype", iTween.EaseType.linear));
		iTween.ScaleTo (img07, iTween.Hash ("x", 1F,  "time", 4F, "delay", 3F, "easetype", iTween.EaseType.linear));
		iTween.ScaleTo (img08, iTween.Hash ("x", 1F,  "time", 4F, "delay", 3.5F, "easetype", iTween.EaseType.linear));


		StartCoroutine (changeOrder (4F, img01));
		StartCoroutine (changeOrder (4.5F, img02));
		StartCoroutine (changeOrder (5F, img03));
		StartCoroutine (changeOrder (5.5F, img04));
		StartCoroutine (changeOrder (6F, img05));
		StartCoroutine (changeOrder (6.5F, img06));
		StartCoroutine (changeOrder (7F, img07));
		StartCoroutine (changeOrder (7.5F, img08));

		StartCoroutine (delayAnimation ());
		//}
	
		//img04.GetComponent<RectTransform> ().SetAsLastSibling ();
	
	}

	IEnumerator delayAnimation() {
		yield return new WaitForSeconds (4F);
		//setAllScaleZero ();
		startAnimation ();

	}

	IEnumerator changeOrder(float wait, GameObject obj) {
		yield return new WaitForSeconds (wait);
		obj.GetComponent<RectTransform> ().SetAsLastSibling ();
		obj.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
	}


	void setAllScaleZero() {
		img01.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
		img02.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
		img03.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
		img04.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
		img05.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
		img06.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
		img07.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
		img08.GetComponent<RectTransform>().localScale = new Vector3(0F, 1F, 1F); 
	}



}
