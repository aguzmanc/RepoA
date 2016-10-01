using UnityEngine;
using System.Collections;

public class MasAdelante : Personajes {

    public float velocidad = 10f;
    public float tiempo=5f;


    public MasAdelante(bool Lento) : base(Lento)
    {
    }

    void Start()
    {

    }

    void Update()
    {
        if(tiempo<0)
            Destroy(this.gameObject);
        tiempo = tiempo - Time.deltaTime * SlowAction;
        transform.position = transform.position + transform.forward * SlowAction*10f;
    }
}
