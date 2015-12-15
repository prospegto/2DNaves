using UnityEngine;
using System.Collections;

public class DisparoEnemigo : MonoBehaviour {

	public Vector3 balaDirecc = new Vector3(0, 0.5f, 0);	
	public GameObject bala;
	public float retardoBala = 0.50f;
	private int layerBala;
	private float proxDisparo = 0;
	private Transform jugadr;
	public float distanciaDisparo = 5f;


	void Start() {
		layerBala = gameObject.layer;
	}

	void Update () {

		if(jugadr == null) {
			GameObject mJugador = GameObject.FindWithTag ("Player");
			
			if(mJugador != null) {
				jugadr = mJugador.transform;
			}
		}


		proxDisparo -= Time.deltaTime;
		
		if( proxDisparo <= 0 && jugadr != null && Vector3.Distance(transform.position, jugadr.position) < distanciaDisparo) {
			proxDisparo = retardoBala;	
			Vector3 direcc = transform.rotation * balaDirecc;	
			GameObject mBala = (GameObject)Instantiate(bala, transform.position + direcc, transform.rotation);
			Destroy(mBala, 1.5f);
			mBala.layer = layerBala;
		}
	}
}
