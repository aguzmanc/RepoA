using UnityEngine;
using System.Collections;

public class Personajes : MonoBehaviour {

    float _slowAction=10f;
    public float SlowAction
    {
        get { return _slowAction; }
        set { _slowAction = value; }
    }

   

    bool _lento;
    public bool Lento
    {
        get { return _lento; }
        set { _lento = value; }
    }

    public Personajes(float SlowAction, bool Lento)
    {
        this.SlowAction = SlowAction;
        this.Lento = Lento;
    }
    void Start () {
	
	}
	
	void Update () {
           

        }

    public float Realentizar(bool Lento)
    {
        if (Lento) {
            return 0.1f;
        }
        else { 
            return 1f;
            
        }
    }
}
