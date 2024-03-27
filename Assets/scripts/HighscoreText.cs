using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class HighscoreText : MonoBehaviour {

	Text text;

		void OnCountdownFinished(){
			text = GetComponent<Text>();
			text.enabled = false;
		}	
}
