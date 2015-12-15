using UnityEngine;
using System.Collections;

public class MoverJugador : MonoBehaviour {

	public float maxVelocidad = 5f;
	public float velocidadRotacion = 180f;
	private float bordePantalla = 0.33f;

	void Start () {
	
	}
	
	void Update () {

		// Movimiento y rotación del jugador
		Quaternion rotacion = transform.rotation;
		float zProfundidad = rotacion.eulerAngles.z;
		zProfundidad -= Input.GetAxis("Horizontal") * velocidadRotacion * Time.deltaTime;
		rotacion = Quaternion.Euler( 0, 0, zProfundidad );
		transform.rotation = rotacion;
		Vector3 pos = transform.position;	 
		Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxVelocidad * Time.deltaTime, 0);
		pos += rotacion * velocity;

		// Restringir la pantalla al tamaño de pantalla solo para el jugador
		if(pos.y+bordePantalla > Camera.main.orthographicSize) {
			pos.y = Camera.main.orthographicSize - bordePantalla;
		}
		if(pos.y-bordePantalla < -Camera.main.orthographicSize) {
			pos.y = -Camera.main.orthographicSize + bordePantalla;
		}


		// Corregir los bordes de pantalla
		float ratioPantalla = (float)Screen.width / (float)Screen.height;
		float tamanoOrto = Camera.main.orthographicSize * ratioPantalla;

		if(pos.x+bordePantalla > tamanoOrto) {
			pos.x = tamanoOrto - bordePantalla;
		}
		if(pos.x-bordePantalla < -tamanoOrto) {
			pos.x = -tamanoOrto + bordePantalla;
		}

		transform.position = pos;

	}
}
