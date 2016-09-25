using UnityEngine;
using System.Collections;

public class Adelante : Personajes {
    public float velocidad = 1f;
    

    public Adelante(float SlowAction, bool Lento) : base(SlowAction, Lento)
    {
    }
    
    void Start () {
        
    }
	
	void Update () {
        bool slow = Lento;

        SlowAction = Realentizar(slow);
        
        transform.position = transform.position + transform.forward * SlowAction;
	}
}
