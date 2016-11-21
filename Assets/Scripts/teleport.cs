﻿using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {
public Transform destino;

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player") {
			objeto.transform.position = destino.position;
		}
	}
	void OnDrawGizmosSelected(){
		if (destino != null) {
			Gizmos.color = Color.yellow;
			Gizmos.DrawLine (transform.position, destino.position);

		}
	}
	void OnDrawGizmos(){
		if (destino != null) {
			Gizmos.color = Color.grey;
			Gizmos.DrawLine (transform.position, destino.position);

		}
	}
}
