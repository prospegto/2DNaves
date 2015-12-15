using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnJugador : MonoBehaviour {

	public GameObject jugador;
	private GameObject mJugador;
	public int numVidas = 5;
	public float tiempoAparicion;
	public Text textoPuntuacion;
	public Text textoVidas;

	
	void Start () {
		Aparecer();
	}

	void Aparecer() {
		numVidas--;
		tiempoAparicion = 1;
		mJugador = (GameObject)Instantiate(jugador, transform.position, Quaternion.identity);
	}

	void Update () {
		if(mJugador == null && numVidas > 0) {
			tiempoAparicion -= Time.deltaTime;

			if(tiempoAparicion <= 0) {
				Aparecer();
			}
		}

		if(numVidas > 0 || mJugador!= null) {
			textoVidas.text = numVidas + " vidas";
		}
		else {
			textoVidas.text = "Game over";
			
		}
	}


}
