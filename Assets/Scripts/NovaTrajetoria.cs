using UnityEngine;
using System.Collections;

public class NovaTrajetoria : MonoBehaviour {
	public GameObject player;
	private MovePlayer ref_playerControl;
	public GameObject coletavelRepres, inimigoRepres;
	// Use this for initialization
	void Start () {
		ref_playerControl = player.GetComponent<MovePlayer> ();
	}
	
	// Update is called once per frame
	void Update () {
		//muda de lugar
		if (Input.GetButtonDown ("Fire1")) 
		{
			//novaTrajetoria();
		}
	}
	public void novaTrajetoria(){
		if (Time.timeScale != 0) {
			ref_playerControl.comecou = true;
			if(inimigoRepres != null){
				inimigoRepres.GetComponent<Gira>().Comecou();
			}
			Vector3 mousePos = Input.mousePosition;
			mousePos.z = 2.0f;       // we want 2m away from the camera position
			transform.position = Camera.main.ScreenToWorldPoint(mousePos);
			calculaNovoPontilhado();
			ref_playerControl.mudaSentidoRotacao();
			coletavelRepres.GetComponent<Coletavel> ().mudaSentidoRotacao ();
		}

	}
	void calculaNovoPontilhado(){
		float raio = Vector2.Distance (player.transform.position, transform.position);
		transform.GetChild(1).transform.localScale = new Vector2(raio*0.4f, raio *0.4f);
	}
}
