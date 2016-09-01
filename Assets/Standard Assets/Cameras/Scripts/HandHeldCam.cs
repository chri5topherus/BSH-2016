using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace UnityStandardAssets.Cameras
{
    public class HandHeldCam : LookatTarget
    {
        [SerializeField] private float m_SwaySpeed = .01f;
        [SerializeField] private float m_BaseSwayAmount = .01f;
        //[SerializeField] private float m_TrackingSwayAmount = .0f;
        //[Range(-1, 1)] [SerializeField] private float m_TrackingBias = 0;

		private Vector3 StartPosition;
		private int counter;
		private bool waitForReachedPos;
		private float bx;
		private float by;

		private float waitingFloat;
		public Text waitingTimeTXT;

		private bool running;

		void Start () {
			waitingFloat = float.Parse (waitingTimeTXT.text);
			running = false;
		}

		private void startMotion() {
			waitingFloat = float.Parse (waitingTimeTXT.text);
			running = true;
			StartPosition = new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z);
			counter = 0;
			waitForReachedPos = false;
		}
			
		public void stopRunning() {
			running = false;
			waitingFloat = float.Parse (waitingTimeTXT.text);
			StartCoroutine(startRunning());
		} 

		public void stopRunningWithoutContinue() {
			running = false;
		}


		private IEnumerator startRunning() {
			//TODO
			yield return new WaitForSeconds (waitingFloat+0.5F);
			startMotion ();
		}

        protected override void FollowTarget(float deltaTime)
        {
			if (running) {
			
				// base.FollowTarget(deltaTime);


				bx = (Mathf.PerlinNoise (0, Time.time * m_SwaySpeed) - 0.5f);
				by = (Mathf.PerlinNoise (0, (Time.time * m_SwaySpeed) + 100)) - 0.5f;

				bx *= m_BaseSwayAmount;
				by *= m_BaseSwayAmount;


				//if below certain level add value until at startPosition (all 4 axis) 

				if (transform.position.x < StartPosition.x - 1F) {
					Debug.Log ("small");
					bx = 0.01f;
				} 

				if (transform.position.x > StartPosition.x + 1F) {
					Debug.Log ("big");
					bx = -0.01f;
				}

				if (transform.position.z < StartPosition.z - 1F) {
					Debug.Log ("small2");
					by = 0.01f;
				} 

				if (transform.position.z > StartPosition.z + 1F) {
					Debug.Log ("big2");
					by = -0.01f;
				}

				transform.Translate (bx, 0, by);

			}
        }
    }
}
