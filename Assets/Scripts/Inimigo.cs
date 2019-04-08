using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour {
	private GameResponsibilities refGameResps;
	// Use this for initialization
	void Start () {
		refGameResps = GameObject.Find("Game Manager").GetComponent<GameResponsibilities> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) {
		GetComponent<SpriteRenderer> ().color = new Color (1,1,1);
		if (other.name == "Player") {
			refGameResps.gameOver();
		}
	}

}
