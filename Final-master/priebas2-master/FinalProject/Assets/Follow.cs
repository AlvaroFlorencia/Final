using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {
	public GameObject RedCube;
	public GameObject point1;
	public GameObject point2;
	public GameObject point3;
	public GameObject point4;
	public GameObject point5;
	public GameObject point6;
	public GameObject point7;
	public GameObject point8;
	public GameObject point9;
	public GameObject point10;
	public GameObject point11;
	public GameObject point12;

	public int pin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (pin == 0) {
			
			RedCube.transform.position = point1.transform.position;
		

		}
		if (pin == 1) {
			RedCube.transform.position = point2.transform.position;

		}
		if (pin == 2) {
			
			RedCube.transform.position = point3.transform.position;
		}
		if (pin == 3) {
			
			RedCube.transform.position = point4.transform.position;
		}
		if (pin == 4) {
			
			RedCube.transform.position = point5.transform.position;
		}
		if (pin == 5) {
			
			RedCube.transform.position = point6.transform.position;
		}
		if (pin == 6) {

			RedCube.transform.position = point7.transform.position;
		}
		if (pin == 7) {

			RedCube.transform.position = point8.transform.position;
		}
		if (pin == 8) {

			RedCube.transform.position = point9.transform.position;
		}

		if (pin == 9) {

			RedCube.transform.position = point10.transform.position;
		}
		if (pin == 10) {

			RedCube.transform.position = point11.transform.position;
		}
		if (pin == 11) {

			RedCube.transform.position = point11.transform.position;
		}

	}
	IEnumerator OnTriggerEnter(Collider collider){
		
		if (collider.gameObject.tag == "Car2") {
			pin++;
				if(pin==12){
					pin=0;

				}
		}
		yield return new WaitForSeconds(1);
		this.GetComponent<BoxCollider>().enabled=true;
	}
}
