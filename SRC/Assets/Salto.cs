using UnityEngine;
using System.Collections;

public class Salto : MonoBehaviour {
    Rigidbody _rb;

    public float Fuerza = 100;

	void Start () {
        _rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(0, Fuerza, 0);
            
        }
	
	}

    void OntriggerStay(Collider C)
    {
        
    }
}
