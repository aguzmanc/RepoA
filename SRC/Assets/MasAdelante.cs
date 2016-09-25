using UnityEngine;
using System.Collections;

public class MasAdelante : Personajes {

    public float velocidad = 10f;


    public MasAdelante(float SlowAction, bool Lento) : base(SlowAction, Lento)
    {
    }

    void Start()
    {

    }

    void Update()
    {
        bool slow = Lento;

        SlowAction = Realentizar(slow);

        transform.position = transform.position + transform.forward * SlowAction*10f;
    }
}
