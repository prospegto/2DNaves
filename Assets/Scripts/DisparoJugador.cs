using UnityEngine;
using System.Collections;

public class DisparoJugador : MonoBehaviour {

	public Vector3 direcBala = new Vector3(0, 0.5f, 0);
	public GameObject bala;
	public float retardoBala = 0.25f;
	float proxDisparo = 0;
	// Para que no afecten las propias balas
	private int layerBala;

	void Start() {
		layerBala = gameObject.layer;
	}
	
	void Update () {
		proxDisparo -= Time.deltaTime;

		if( Input.GetButton("Fire1") && proxDisparo <= 0 ) {
			proxDisparo = retardoBala;
			Vector3 direc = transform.rotation * direcBala;
			GameObject mBala = (GameObject)Instantiate(bala, transform.position + direc, transform.rotation);
			mBala.layer = layerBala;
			Destroy(mBala, 2);
		}
	}
}
