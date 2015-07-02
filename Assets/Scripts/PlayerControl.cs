using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
		public enum Shape
		{
				Square,
				Circle
		}
	
		public GameObject circle, square, gameControl;
		public Shape defaultShape;
		Shape shape;
		bool finished;
		
		public void setShape (Shape shape)
		{
				this.shape = shape;

				switch (shape) {
				case Shape.Circle:
						square.SetActive (false);
						circle.SetActive (true);
						break;
				case Shape.Square:
						square.SetActive (true);
						circle.SetActive (false);
						break;
				}
		}

		// Use this for initialization
		void Start ()
		{
				setShape (defaultShape);
				finished = false;
		}
	
		// Update is called once per frame
		void Update ()
		{
		}

		void OnTriggerEnter2D (Collider2D other)
		{
				Debug.Log ("OnTriggerEnter2D");
				
				if (other.tag.Contains (shape.ToString ())) {
//						other.audio.Play ();
						Destroy (other.gameObject);
						GetComponent<AudioSource>().Play ();
						gameControl.SendMessage ("AddScore", 0, SendMessageOptions.DontRequireReceiver);
				} else {
						finished = true;			
						gameControl.SendMessage ("StopTimer", 0, SendMessageOptions.DontRequireReceiver);
				}

		}

		void Clicked ()
		{
				Debug.Log ("Player Clicked!");

				if (!finished) {
						switch (shape) {
						case Shape.Circle:
								setShape (Shape.Square);
								break;
						case Shape.Square:
								setShape (Shape.Circle);
								break;
						}
				}
		}

}
