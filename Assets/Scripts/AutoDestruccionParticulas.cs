using UnityEngine;
using System.Collections;

public class AutoDestruccionParticulas : MonoBehaviour {

	ParticleSystem sistema_particulas;

	// Use this for initialization
	void Start () {
		sistema_particulas = GetComponent<ParticleSystem> ();
		Destroy (gameObject, sistema_particulas.duration);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
