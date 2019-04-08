using UnityEngine;
using System.Collections;

public class Gira : MonoBehaviour {
	public float velRot;
	private static bool comecou;

	void Awake(){
		comecou = false;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(comecou){
			transform.Rotate (0,0, velRot*Time.deltaTime);
		}
	}
	public void Comecou(){
		comecou = true;
	}
}
