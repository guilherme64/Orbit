using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameResponsibilities : MonoBehaviour {
	// Use this for initialization
	int nextLevel;
	void Start () {
		
		string nomeFase = (SceneManager.GetActiveScene ().name);
		int.TryParse (nomeFase, out nextLevel);
		nextLevel++;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void gameOver(){
		//Camera.main.gameObject.GetComponent<BlurOptimized>().enabled = true;
		GameObject.Find ("Player").GetComponent<MovePlayer> ().freia();
		Invoke ("restart", 0.5f);
	}
	public void vitoria(){
		//Camera.main.gameObject.GetComponent<BlurOptimized>().enabled = true;
		GameObject.Find ("Player").GetComponent<MovePlayer> ().freia();
		Application.LoadLevel(nextLevel);
	}
	public void menu(){
		Application.LoadLevel("menu");
		Time.timeScale = 1;
	}
	private void restart(){
		Application.LoadLevel(Application.loadedLevel);
	}
}
