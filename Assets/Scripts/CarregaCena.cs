using UnityEngine;
using System.Collections;

public class CarregaCena : MonoBehaviour {

	// Use this for initialization

	public void carregaNivel(int nivel){
		Application.LoadLevel(nivel);
	}
}
