using UnityEngine;
using System.Collections;

public class Personajes : MonoBehaviour {

    public static float SlowAction;

    bool _alzado;
    public bool Alzado
    {
        get { return _alzado; }
        set { _alzado = value; }
    }

    bool _lento;
    public bool Lento
    {
        get { return _lento; }
        set { _lento = value; }
    }

    public Personajes(bool Lento, bool Alzado)
    {
        this.Lento = Lento;
        this.Alzado = Alzado;
    }

    public Personajes(bool lento)
    {
        Lento = lento;
    }

    void Start () {
        Alzado = false;
	
	}
	
	void Update () {
        if (Lento)
            SlowAction = 0.1f;
        else
            SlowAction = 1f;
        if (Alzado == false)
            transform.position = transform.position - transform.up * 1;
        }
    
        

    
}
