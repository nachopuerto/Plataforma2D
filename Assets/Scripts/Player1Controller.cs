using UnityEngine;
using System.Collections;

public class Player1Controller : MonoBehaviour {
	Animator anim;
	Rigidbody2D rigi;
	public float fuerza = 1;
	public float fsalto = 100;
	public bool tocando_suelo = false;
	private GameControlScript gcs;

	// Use this for initialization
	void Start () {
		gcs = GameObject.Find ("GameControl").GetComponent<GameControlScript> ();
		anim = GetComponent<Animator> (); // Coger el Animator de el elemento que tenga el script
		rigi = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		anim.SetFloat ("velocidad", Mathf.Abs (rigi.velocity.x));
		if (Input.GetKey (KeyCode.RightArrow)) {
			anim.SetFloat ("velocidad", 1f);
			rigi.AddForce (transform.right*fuerza);
			transform.localScale = new Vector3 (1, 1, 1);
		}

		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			anim.SetFloat ("velocidad", 0f);

		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			anim.SetFloat ("velocidad", 1f);
			rigi.AddForce (transform.right*-fuerza);
			transform.localScale = new Vector3 (-1, 1, 1);
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			anim.SetFloat ("velocidad", 0f);

		}

		if (Input.GetKeyDown (KeyCode.Space)&& tocando_suelo) {
			anim.SetBool  ("jump", true);
			rigi.AddForce (transform.up*fsalto);
		}

		if (Input.GetKeyUp (KeyCode.Space)) {
			anim.SetBool ("jump", false);
		

		}
	}

	void OnTriggerStay2D(Collider2D objeto){
		if (objeto.tag == "Suelo") {
			tocando_suelo = true;
		}
	}

	void OnTriggerExit2D(Collider2D objeto){
		if (objeto.tag == "Suelo") {
			tocando_suelo = false;

		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "muerte") {
			gcs.respaw ();
		}
	}
}
