using UnityEngine;
using System.Collections;

public class EncontrarJugador : MonoBehaviour {

	public float velRotacion = 90f;
	private Transform jugador;
	
	void Update () {
		if(jugador == null) {
			GameObject mJugador = GameObject.FindWithTag ("Player");
			if(mJugador != null) {
				jugador = mJugador.transform;
			}
		}

		// + frame
		if(jugador == null)
			return;


		Vector3 dir = jugador.position - transform.position;
		dir.Normalize();
		float anguloZ = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
		Quaternion jRotacion = Quaternion.Euler( 0, 0,anguloZ );
		transform.rotation = Quaternion.RotateTowards( transform.rotation, jRotacion, velRotacion * Time.deltaTime);

	}
}
