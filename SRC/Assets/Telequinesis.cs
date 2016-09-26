using UnityEngine;
using System.Collections;

public class Telequinesis : MonoBehaviour {
    public float Suavidad = 0.05f;
    public GameObject Boton;

    bool _posible;
    public bool Posible
    {
        get { return _posible; }
        set { _posible = value; }
    }

    void Start () {
	
	}
	
	void Update () {
            
    }


    void OnTriggerEnter(Collider C)
    {
        if(C.tag=="Alzable")
        {
            Instantiate(Boton);
            
        }
    }
    void OnTriggerStay(Collider C)
    {
        if(Posible)
         C.transform.position = Vector3.Lerp(C.transform.position, transform.position, Suavidad);
    }
    void OnTriggerExit(Collider C)
    {
        if (C.tag == "Alzable")
            Destroy(Boton);
    }


}
