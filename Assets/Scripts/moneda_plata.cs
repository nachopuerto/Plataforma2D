using UnityEngine;
using System.Collections;

public class moneda_plata : MonoBehaviour {
	private Rigidbody2D rb;
	GameObject texto_moneda;
	control_text_monedas cm;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 10);
		//Random.Range (0,10);
		rb = GetComponent<Rigidbody2D> ();
		//rb.AddForce (new Vector2 (Random.Range(-200,200), 200));
		texto_moneda = GameObject.Find ("Text_mon");
		cm = texto_moneda.GetComponent<control_text_monedas> ();
	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			cm.suma_monedas (5);
			Destroy (gameObject);
		}
	}
}
