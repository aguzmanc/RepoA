using UnityEngine;
using System.Collections;

public class Adelante : Personajes {
    public float velocidad = 1f;
    

    public Adelante(bool Lento) : base(Lento)
    {
    }
    
    void Start () {
        
    }
	
	void Update () {
        
        
        transform.position = transform.position + transform.forward * SlowAction;
	}
}
