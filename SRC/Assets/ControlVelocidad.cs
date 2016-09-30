using UnityEngine;
using System.Collections;

public class ControlVelocidad : Personajes {
    Rigidbody _rb;
    Vector3 Velocidad;

    public Telequinesis Telequinesis;
    public ControlVelocidad(bool Lento) : base(Lento)
    {
    }
    void Start () {
        _rb = GetComponent<Rigidbody>();
        

    }
	
	void Update () {
        Velocidad = Telequinesis.VelocidadDeLanzamiento;
        if (SlowAction == 1)
            _rb.velocity = Velocidad;
        else
            _rb.velocity = Velocidad * SlowAction;

	
	}
}
