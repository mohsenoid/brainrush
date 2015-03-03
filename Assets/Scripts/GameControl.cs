using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
		int score, highscore;
		public Text scoreText;
//		public List<Font> fonts = new List<Font> ();

		// Use this for initialization
		void Start ()
		{
				score = 0;
				highscore = PlayerPrefs.GetInt ("High Score");
//				Font desiredFont = fonts [(int)DisplayMetricsUtil.GetResolutionType ()]; 
//				scoreText.font = desiredFont;
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKeyDown (KeyCode.Escape))
//						Application.Quit ();
						Application.LoadLevel ("Menu");
		}

		void AddScore ()
		{
				score++;

				PlayerPrefs.SetInt ("Last Score", score);

				if (score > highscore) { //when player dies set highscore = to that score
						highscore = score;
						PlayerPrefs.SetInt ("High Score", highscore);
			
						Debug.Log ("High Score is " + highscore);
			
				}    
//				scoreText.text = score + "";
		}

//		float originalWidth = 640.0f;  // define here the original resolution
//		float originalHeight = 400.0f; // you used to create the GUI contents 
//		Vector3 scale;

//		void OnGUI ()
//		{
////				scale.x = Screen.width / originalWidth; // calculate hor scale
////				scale.y = Screen.height / originalHeight; // calculate vert scale
////				scale.z = 1;
//				//var svMat = GUI.matrix; // save current matrix
//				// substitute matrix - only scale is altered from standard
//				//GUI.matrix = Matrix4x4.TRS (Vector3.zero, Quaternion.identity, scale);
//				// draw your GUI controls here:
////				GUI.TextArea(new Rect (10, 10, 200, 50), score +"");
////				GUI.Button (new Rect (400, 180, 230, 50), "Button");
//				//...
//				// restore matrix before returning
//				//GUI.matrix = svMat; // restore matrix
//
//
//		}


		//a GUISkin object to draw the GUI image  
//		public GUISkin guiSkin;  
//		
//		//the GUI scale ratio  
//		private float guiRatio;  
//		
//		//the screen width  
//		private float sWidth;  
//		
//		//create a scale Vector3 with the above ratio  
//		private Vector3 GUIsF;  
		
		//At this script initialization  
//		void Awake ()
//		{  
//				//get the screen's width  
//				sWidth = Screen.width;  
//				//calculate the scale ratio  
//				guiRatio = sWidth / 1920;  
//				//create a scale Vector3 with the above ratio  
//				GUIsF = new Vector3 (guiRatio, guiRatio, 1);  
//		}  
		
		//Draws GUI elements  
		void OnGUI ()
		{  
//				//scale and position the GUI element to draw it at the screen's top left corner  
//				GUI.matrix = Matrix4x4.TRS (new Vector3 (GUIsF.x, GUIsF.y, 0), Quaternion.identity, GUIsF);  
//				//draw GUI on the top left  
//				GUI.Label (new Rect (20, 20, 258, 89), "test");//,guiSkin.customStyles[0]);  
//			
//				//scale and position the GUI element to draw it at the screen's bottom right corner  
//				GUI.matrix = Matrix4x4.TRS (new Vector3 (Screen.width - 258 * GUIsF.x, Screen.height - 89 * GUIsF.y, 0), Quaternion.identity, GUIsF);  
//				//draw GUI on the bottom right  
//				GUI.Label (new Rect (-20, -20, 258, 89), "yes");//,guiSkin.customStyles[0]);  

				scoreText.text = score + "";
		}  


}
