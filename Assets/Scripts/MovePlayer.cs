using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {
	//orbita o player em torno do gameObject trajetoria
	public GameObject rotateAroundObject;
	Vector3 rotationMask; //which axes to rotate around
	public float rotationSpeed; //degrees per second
	public bool comecou;
	public GameObject bolinha;
	void Awake(){
		rotationMask = new Vector3 (0, 0, 1);
		comecou = false;
	}
	void Start(){
		InvokeRepeating ("peidaBolinha", 0, 0.1f);
	}
	void FixedUpdate() {
		if (comecou) {
			if (rotateAroundObject != null) {//If true in the inspector orbit <rotateAroundObject>:
				//Debug.Log("achei orbitando: "+rotateAroundObject);
				transform.RotateAround (rotateAroundObject.transform.position, rotationMask, rotationSpeed * Time.deltaTime);
			} else {//not set -> rotate around own axis/axes:
				//Debug.Log("nao achei girando: "+rotateAroundObject);
				transform.Rotate (
					rotationMask.x * rotationSpeed * Time.deltaTime,
					rotationMask.y * rotationSpeed * Time.deltaTime,
					rotationMask.z * rotationSpeed * Time.deltaTime
				);
			}
		}
	}
	void peidaBolinha(){
		Instantiate (bolinha, transform.position, Quaternion.identity);
	}
	public void mudaSentidoRotacao(){
		rotationMask.z *= -1;
		mantemVelEscalar ();
	}
	public void freia(){
		rotationMask.z *= 0;
		rotateAroundObject.SetActive (false);
	}
	void mantemVelEscalar(){
		float raio = Vector2.Distance (rotateAroundObject.transform.position, transform.position);
		float compCirc = 2 * Mathf.PI * raio;
		rotationSpeed = 13/compCirc * 150;
		Debug.Log ("comprimento: " +compCirc);
		Debug.Log ("vel ang: " +rotationSpeed);
	}
}
