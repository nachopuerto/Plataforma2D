﻿using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {
	private GameControlScript gcs;
	public Sprite banderaActivada;
	private bool activada = false;

	void Start () {
		gcs= GameObject.Find ("GameControl").GetComponent<GameControlScript> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player" && !activada) {
			GetComponent<SpriteRenderer> ().sprite = banderaActivada;
			gcs.checkpoint (transform.position);
			activada = true;

		}
	}
}
