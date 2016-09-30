using UnityEngine;
using System.Collections;

public class MasAdelante : Personajes {

    public float velocidad = 10f;


    public MasAdelante(bool Lento) : base(Lento)
    {
    }

    void Start()
    {

    }

    void Update()
    {
        Destroy(this.gameObject, 5);
        transform.position = transform.position + transform.forward * SlowAction*10f;
    }
}
