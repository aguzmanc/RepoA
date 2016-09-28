using UnityEngine;
using System.Collections;

public class Personajes : MonoBehaviour {

    public static float SlowAction;
    
   

    bool _lento;
    public bool Lento
    {
        get { return _lento; }
        set { _lento = value; }
    }

    public Personajes(bool Lento)
    {
        this.Lento = Lento;
    }
    void Start () {
	
	}
	
	void Update () {
        if (Lento)
            SlowAction = 0.1f;
        else
            SlowAction = 1f;
        }

    
}
