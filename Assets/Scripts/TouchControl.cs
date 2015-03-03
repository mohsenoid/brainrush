using UnityEngine;
using System.Collections;

public class TouchControl : MonoBehaviour
{
		RuntimePlatform platform = Application.platform;
		public GameObject player;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (platform == RuntimePlatform.Android || platform == RuntimePlatform.IPhonePlayer) {
						if (Input.touchCount >= 0) {
								if (Input.GetTouch (0).phase == TouchPhase.Began || Input.GetTouch (0).phase == TouchPhase.Ended) {
										checkTouch (Input.GetTouch (0).position);
								}
						}
				} else if (platform == RuntimePlatform.WindowsEditor || platform == RuntimePlatform.OSXEditor) {
						//mouse click
						if (Input.GetMouseButtonDown (0) || Input.GetMouseButtonUp (0)) {
								checkTouch (Input.mousePosition);
						}

						// space
						if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyUp (KeyCode.Space)) {
								checkTouch (Input.mousePosition);
						}
				}
		}

		void checkTouch (Vector3 pos)
		{
//				Vector3 wp = Camera.main.ScreenToWorldPoint (pos);
//				Vector2 touchPos = new Vector2 (wp.x, wp.y);
//				Collider2D hit = Physics2D.OverlapPoint (touchPos);
		
//				if (hit) {
//						Debug.Log (hit.transform.gameObject.name);
//						hit.transform.gameObject.SendMessage ("Clicked", 0, SendMessageOptions.DontRequireReceiver);
//				}

				Debug.Log ("Touched!" + pos.ToString ());
				player.SendMessage ("Clicked", 0, SendMessageOptions.DontRequireReceiver);
		}
}
