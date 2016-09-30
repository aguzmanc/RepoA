using UnityEngine;
using System.Collections;

public class Saltar : MonoBehaviour {
    public float Fuerza = 150f;

	void Start () {
	
	}
	
	void Update () {
	
	}
    void OnTriggerEnter(Collider C)
    {
        if(C.tag=="Player")
        {
            Rigidbody Rb = C.GetComponent<Rigidbody>();
            Rb.AddForce(0, Fuerza, 0);
        }
    }
}
