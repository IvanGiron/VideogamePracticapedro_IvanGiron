using UnityEngine;
using System.Collections;

public class SalirJuego : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player") {
			Application.Quit();
			Destroy (gameObject);
		}
	}
}
