using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour
{
		public GameObject squarePrefabs, circlePrefabs;
		public Transform releasePoint;
		public float speed;
		public float speedPace;
		public float timeDelay;
		public float timePace;
		float respawnTimer;

		// Use this for initialization
		void Start ()
		{
//				while (true) {
//						yield return new WaitForSeconds (timeDelay);
//
//						GameObject newShape;
//			
//						int random = Random.Range (0, 1);
//						if (random == 1)
//								newShape = (GameObject)Instantiate (squarePrefabs, releasePoint.position, Quaternion.identity);
//						else
//								newShape = (GameObject)Instantiate (circlePrefabs, releasePoint.position, Quaternion.identity);
//			
//						newShape.rigidbody2D.AddForce (new Vector2 (-speed, 0));
//				} 

				//first enemy
				respawnTimer = timeDelay;
		}
	
		// Update is called once per frame
		void FixedUpdate ()
		{
				if (timeDelay != -1) {
						respawnTimer += Time.deltaTime;
						if (respawnTimer > timeDelay) {
								respawnTimer = 0f;

								GameObject newShape;
			
								int random = Random.Range (0, 2);
//						Debug.Log (random + "");

								if (random == 0) {
										newShape = (GameObject)Instantiate (squarePrefabs, releasePoint.position, Quaternion.identity);
								} else {
										newShape = (GameObject)Instantiate (circlePrefabs, releasePoint.position, Quaternion.identity);
								}
								newShape.rigidbody2D.AddForce (Vector2.up * -speed);

								speed += speedPace;
								timeDelay -= timePace;


						}
				}

		}

		void StopTimer ()
		{
				timeDelay = -1;
		
				foreach (GameObject square in GameObject.FindGameObjectsWithTag("Square")) {
						square.rigidbody2D.Sleep ();//.AddForce (Vector2.right*100);
						//Destroy (square);
				}

				foreach (GameObject circle in GameObject.FindGameObjectsWithTag("Circle")) {
						circle.rigidbody2D.Sleep ();//.AddForce (Vector2.right*100);
						//Destroy (circle);
				}

				audio.Play ();

				Application.LoadLevel ("Menu");
		}
}
