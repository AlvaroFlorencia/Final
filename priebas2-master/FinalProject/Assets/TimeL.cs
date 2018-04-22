using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeL : MonoBehaviour {
	public static int Minute;
	public static int Sec;
	public static float Mili;
	public static string MiliDis;
	public GameObject MinBox;
	public GameObject SecBox;
	public GameObject MilBox;
	public static float RawTime;
	private LevelManager levelManager;





	// Update is called once per frame
	void Update () {
		levelManager = FindObjectOfType<LevelManager>();
		Mili += Time.deltaTime * 10;
		RawTime += Time.deltaTime;
		MilBox.GetComponent<Text> ().text = "" + MiliDis;
		if (Mili >= 10) {
			Mili = 10;
			Sec += 1;
		}
		if (Sec <= 9) {
			SecBox.GetComponent<Text> ().text = "0" + Sec+".";
		} else {
			SecBox.GetComponent<Text> ().text = "" + Sec+".";
		}

		if (Sec >= 60) {
			Sec = 0;
			Minute += 1;
		}	
		if (Minute <= 9) {
			MinBox.GetComponent<Text> ().text = "0" + Minute + ".";
		} else {
			MinBox.GetComponent<Text> ().text = "" + Minute + ".";
		}

		if (Minute >= 300) {
			levelManager.LoadLevel ("ScorefinalScreen");
		}
	}
}
