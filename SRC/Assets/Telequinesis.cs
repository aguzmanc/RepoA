﻿using UnityEngine;
using System.Collections;

public class Telequinesis : MonoBehaviour {
    public float Suavidad = 0.05f;
    public GameObject Boton;
    public Rigidbody _rb;
    public bool Lanzar=false;

    bool _posible;
    public bool Posible
    {
        get { return _posible; }
        set { _posible = value; }
    }

    void Start () {
	
	}
	
	void Update () {
        if (Input.touchCount > 0)
            Debug.Log(Input.GetTouch(0).position);
        
            
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
                    Vector3 Dedo = Input.GetTouch(0).position;
                    Dedo.z = 8;
                    Debug.Log(Dedo);
                    Vector3 pos = Camera.main.ScreenToWorldPoint(Dedo);
                    Lanzar = false;
                    Posible = false;
                    
                    C.tag = "lanzado";
                    _rb.AddForce(pos);
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
