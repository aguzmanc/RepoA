using UnityEngine;
using System.Collections;

public class Saltar2 : MonoBehaviour {

	public float Fuerza = 1f;
	public GameObject Personaje;


	void Start () 
	{

	}

	void Update () 
	{

	}

	void OnTriggerEnter(Collider C)
	{
		Rigidbody _rb = Personaje.GetComponent<Rigidbody>();
		if(C.tag=="Borde"){
			if(Input.GetKey (KeyCode.LeftShift)){
				_rb.AddForce(0, Fuerza, 0);
			}else{
				//_rb.AddForceAtPosition(0.5f, new Vector3(0,-1,0));
			}

		}
	}
}
