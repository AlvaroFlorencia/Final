using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoardManager : MonoBehaviour {

    public score sc;
    public InputField inp;
    public Text leaderboard;
    public TextAsset scoreBoard;
    string[] scores;

    // Use this for initialization
    void Start () {
        PlayerPrefs.DeleteAll();
        leaderboard.text = "";
        scores = scoreBoard.text.Split("\n"[0]);
        foreach(string s in scores)
        {
            leaderboard.text = leaderboard.text + "\n" + s;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addScore()
    {
        sc = GameObject.FindObjectOfType<score>();
        placeInLeaderboard(inp.text, sc.scorep);
    }

    public void placeInLeaderboard(string name, int score)
    {
        print("Nuevo score de " + name + " con " + score + " puntos ");
        WriteString(name +" - "+ score);
        reloadScoreBoard();
    }
    static void WriteString(string text)
    {
        string path = "Assets/TxtAssets/scoreBoard.txt";

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(text);
        writer.Close();

        //Re-import the file to update the reference in the editor
        AssetDatabase.ImportAsset(path);
        TextAsset asset = Resources.Load("scoreBoard") as TextAsset;
    }

    public void reloadScoreBoard()
    {
        leaderboard.text = "";
        scores = scoreBoard.text.Split("\n"[0]);
        foreach (string s in scores)
        {
            leaderboard.text = leaderboard.text + "\n" + s;
        }
    }
}
