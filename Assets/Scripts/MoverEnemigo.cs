using UnityEngine;
using System.Collections;

public class MoverEnemigo : MonoBehaviour {

	public float maxVelocidad = 5f;
	
	void Update () {
		Vector3 posicion = transform.position;
		Vector3 velocidad = new Vector3(0, maxVelocidad * Time.deltaTime, 0);		
		posicion += transform.rotation * velocidad;
		transform.position = posicion;
	}
}
