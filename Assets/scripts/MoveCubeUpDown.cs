using UnityEngine;
using System.Collections;


public class MoveCubeUpDown : MonoBehaviour {

	private float wait;
	public float duration;

	void Start () {
		wait = Random.value;
		wait *= 4F;
		StartCoroutine(loopingAnimation());
		duration = 2F;

	}

	void Update () {
	
	}

	IEnumerator loopingAnimation() {
		yield return new WaitForSeconds (wait); 
		StartCoroutine (upAnimation ());
	}


	IEnumerator upAnimation() {
		yield return new WaitForSeconds (duration); 
		iTween.MoveTo (this.gameObject, iTween.Hash ("y", 0.095F, "easetype", iTween.EaseType.linear, "time", 1F, "islocal", true));
		StartCoroutine (downAnimation ());
	}


	IEnumerator downAnimation() {
		yield return new WaitForSeconds (duration); 
		iTween.MoveTo (this.gameObject, iTween.Hash ("y", 0.06F, "easetype", iTween.EaseType.linear, "time", 1F, "islocal" , true));
		StartCoroutine (upAnimation ());
	}



}
