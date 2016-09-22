﻿using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {
	
	public float SlowAction=10f;


	bool _arriba;
	public bool Arriba {
		get{ return _arriba;}
		set{ _arriba = value;}
	}

	bool _abajo;
	public bool Abajo {
		get{ return _abajo;}
		set{ _abajo = value;}
	}

	bool _derecha;
	public bool Derecha {
		get{ return _derecha;}
		set{ _derecha = value;}
	}

	bool _izquierda;
	public bool Izquierda {
		get{ return _izquierda;}
		set{ _izquierda = value;}
	}

	void Start () {
		
	}
	
	void Update () 
	{
		//SlowAction = SlowAction * Time.deltaTime;
		if (Arriba)
			transform.position = transform.position + transform.forward * SlowAction;
		if (Abajo)
			transform.position = transform.position + transform.forward * -SlowAction;
		if (Izquierda)
			transform.Rotate(0,-SlowAction*5,0);
		if (Derecha)
			transform.Rotate(0,SlowAction*5,0);
	}



}
