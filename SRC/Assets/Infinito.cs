using UnityEngine;
using System.Collections;

public class Infinito : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = 0.5f * transform.forward + transform.position;
	}
}
