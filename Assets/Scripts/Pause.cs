using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pause : MonoBehaviour {
	public Button list_bt, pause_bt;
	public Sprite play_spr, pause_spr;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void pause(){
		if (Time.timeScale == 0) {
			play();
		} else {
			Time.timeScale = 0;
			pause_bt.image.sprite = play_spr;
			list_bt.gameObject.SetActive (true);
		}

	}
	public void play(){
		Time.timeScale = 1;
		pause_bt.image.sprite = pause_spr;
		list_bt.gameObject.SetActive (false);
	}
	public void list(){
		Application.LoadLevel("menu");
		Time.timeScale = 1;

	}
}
