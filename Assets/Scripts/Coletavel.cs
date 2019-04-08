using UnityEngine;
using System.Collections;

public class Coletavel : MonoBehaviour {
	private GameResponsibilities refGameResps;
	private static int qtdeColets=0, qtdeRestante=0, sentidoRotacao;

	void Awake(){
		qtdeColets = 0;
		qtdeRestante = 0;
	}

	// Use this for initialization
	void Start () {
		sentidoRotacao = -1;
		qtdeColets++;
		qtdeRestante = qtdeColets;
		refGameResps = GameObject.Find("Game Manager").GetComponent<GameResponsibilities> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0, Time.deltaTime * 50 *sentidoRotacao);
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.name == "Player") {
			Destroy(gameObject);
			qtdeRestante--;
			if(qtdeRestante <= 0){
				refGameResps.vitoria();
			}
		}
	}

	public void mudaSentidoRotacao(){
		sentidoRotacao *= -1;
	}
}
