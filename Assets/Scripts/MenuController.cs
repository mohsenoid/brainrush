using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

		public GameObject highScoreText;
		public GameObject lastScoreText;
		int highScore, lastScore;
		// Use this for initialization
		void Start ()
		{
				highScore = PlayerPrefs.GetInt ("High Score");
				Text txtHighScore = highScoreText.GetComponent<Text> (); 
				txtHighScore.text = "High Score\n" + highScore;

				lastScore = PlayerPrefs.GetInt ("Last Score");
				Text txtLastScore = lastScoreText.GetComponent<Text> (); 
				txtLastScore.text = "Last Score\n" + lastScore;
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKeyDown (KeyCode.Escape))
						Application.Quit ();
		}

		public void StartGame ()
		{
				Application.LoadLevel ("Main");
		}
}
