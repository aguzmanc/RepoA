﻿using UnityEngine;
using System.Collections;

public class Telequinesis : MonoBehaviour {
    public float Suavidad = 0.05f;
    public GameObject Boton;
    public Rigidbody _rb;
    public bool Lanzar=false;
    //public Movimiento Movimiento;
    public Vector3 VelocidadDeLanzamiento;

    bool _posible;
    public bool Posible
    {
        get { return _posible; }
        set { _posible = value; }
    }

    void Start () {
	
	}
	
	void Update () {
        //Posible = Input.GetKey(KeyCode.E);
        if (Input.GetKeyDown(KeyCode.E))
            Posible = true;
            
    }


    void OnTriggerEnter(Collider C)
    {
        if(C.tag=="Alzable")
        {
            Boton.SetActive(true);
        }
    }
    void OnTriggerStay(Collider C)
    {
        if (C.tag == "Alzable")
        {
            _rb = C.GetComponent<Rigidbody>();
            _rb.useGravity=false;
            if (Posible) { 
                 C.transform.position = Vector3.Lerp(C.transform.position, transform.position, Suavidad);
                 Lanzar = true;
                if (Lanzar && Input.touchCount > 0 )
                {
                    _rb.AddForce(GetComponentInParent<Transform>().forward * 1000);
                    Lanzar = false;
                    Posible = false;
                    C.tag = "lanzado";
                    VelocidadDeLanzamiento = _rb.velocity;
                }
                bool mouse = Input.GetMouseButtonDown(0);
                if (mouse)
                {
                    
                    _rb.AddForce(GetComponentInParent<Transform>().forward*1000);
                    Lanzar = false;
                    Posible = false;
                    C.tag = "lanzado";
                }
                    
            }
            
        }

    }
    void OnTriggerExit(Collider C)
    {
        if (C.tag == "Alzable" || C.tag == "lanzado")
            { 
            Boton.SetActive(false);
            Posible = false;
            C.tag = "Alzable";
            _rb.useGravity = true;
        }
    }
    


}
