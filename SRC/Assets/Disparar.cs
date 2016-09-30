using UnityEngine;
using System.Collections;

public class Disparar : Personajes {
    public Disparar(bool Lento) : base(Lento)
    {
    }
    public GameObject Bala,Player;
    public float frecuencia = 3f;

    float tiempo=0;

	// Use this for initialization
	void Start () {
        tiempo = frecuencia;
	}
	
	// Update is called once per frame
	void Update () {
        tiempo = tiempo - Time.deltaTime*SlowAction;
        if(tiempo<=0)
        { 
            Instantiate(Bala, transform.position, transform.rotation);
            tiempo = frecuencia;
            transform.LookAt(Player.transform);
        }

    }
}
