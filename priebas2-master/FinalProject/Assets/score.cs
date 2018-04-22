﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

	public  int scorep = 0;  //set the score
	public Text scoreT;  //To obtain the text resource
	private LevelManager levelManager;

	// Use this for initialization
	void Start()
	{

		scoreT = GetComponent<Text> (); //Get the text component

		scoreT.text = "" + scorep;
	}

	// Update is called once per frame
	void Update()
	{
		levelManager = FindObjectOfType<LevelManager>();
	}

	public void gainPoints()
	{
		levelManager.score++;
		scorep++;
		scoreT.text = "" + scorep;
	}
	public void LessPoints()
	{
		levelManager.score--;
		scorep--;
		scoreT.text = "" + scorep;
	}

	public void setScore(int score)  //Set the score
	{
		scorep = score;
		//(    scoreT.text = "" + scorep;  //Update the score
	}
}
