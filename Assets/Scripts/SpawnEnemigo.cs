using UnityEngine;
using System.Collections;

public class SpawnEnemigo : MonoBehaviour {

	public GameObject enemigo;
	public float distanciaEntre = 12f;
	public float tiempoEntre = 5;
	public float proxEnemigo = 1;


	void Update () {
		proxEnemigo -= Time.deltaTime;

		if(proxEnemigo <= 0) {
			proxEnemigo = tiempoEntre;
			tiempoEntre *= 0.9f;
			if(tiempoEntre < 2)
				tiempoEntre = 2;

			// Devuelve un punto random de una esfera de radio 1
			Vector3 direcc = Random.onUnitSphere;
			direcc.z = 0;
			direcc = direcc.normalized * distanciaEntre;
			Instantiate(enemigo, transform.position + direcc, Quaternion.identity);
		}
	}
}
