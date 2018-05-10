using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
//using UnityStandardAssets.Vehicles.Car;

public class checkan : MonoBehaviour {
	public Text texto;
	public Text answer;
    //int score1;
    public TextAsset qtFile;
    public TextAsset ansFile;
    string[] questions = {"¿2+2?","¿3+3?","¿4+4?"};
    string[] answers = { "4", "6", "8" };
    int aleatorio=1000;
	public GameObject Controls;
	public GameObject q;
	public InputField a;
	public GameObject panel;
	public GameObject particle1;
	public GameObject car;
    public CarCtrl carCtrl;
    public bool isOnQuestion = true;
	public score score;
	public int plus=1;

	// Use this for initialization
	void Start () {
        carCtrl = FindObjectOfType<CarCtrl>();
        //questions = qtFile.text.Split("\n"[0]);
        //answers = ansFile.text.Split("\n"[0]);
        aleatorio = Random.Range(0, questions.Length - 1);
    }

    // Update is called once per frame
        void Update () {
        
            if (answers[aleatorio] == answer.text)
            {
                a.text = "";
                if (carCtrl)
                {
                    print("Correcto");
                    score.gainPoints();
                    Controls.SetActive(true);
                    q.SetActive(false);
                    a.gameObject.SetActive(false);
                    panel.SetActive(false);
                    carCtrl.enableControls();
                    particle1.SetActive(false);
                }
                else
                {
                    score.gainPoints();
                    carCtrl = FindObjectOfType<CarCtrl>();
                    Controls.SetActive(true);
                    q.SetActive(false);
                    a.gameObject.SetActive(false);
                    panel.SetActive(false);
                    carCtrl.enableControls();
                    particle1.SetActive(false);
                
                }
			    Destroy (gameObject);
            }
            else
            {
                
            }
       
        }



    private void OnTriggerEnter(Collider other)
    {
		texto.text = questions[aleatorio];
		print ("tocandome");
        if (other.tag == "Player")
        {
            carCtrl.disableControls();
            Controls.SetActive(false);
            q.SetActive(true);
            a.gameObject.SetActive(true);
            panel.SetActive(true);          
        }
       
    }

}
