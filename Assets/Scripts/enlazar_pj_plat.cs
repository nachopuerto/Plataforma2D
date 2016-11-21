using UnityEngine;
using System.Collections;

public class enlazar_pj_plat : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Player") {
			col.gameObject.transform.parent = transform;
		}
	}
	void OnCollisionExit2D(Collision2D col) {
		if (col.gameObject.tag == "Player") {
			col.gameObject.transform.parent = null;  // null --> Vacio
		}
	}

}
