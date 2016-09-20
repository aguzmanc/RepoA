using UnityEngine;
using System.Collections;

public class DetectarTouch : MonoBehaviour {

	public RectTransform Cursor;
	public RectTransform Gira;

	public float Dot;


	void Start () {
	
	}


	
	void Update () 
	{
		
/*		if (Input.touchCount > 0) {
			Debug.Log (Input.touches [0].position);
			Gira.Rotate (0, 0, 1);
			Cursor.position = Input.touches [0].position;
		}
*/
		if (Input.touchCount >= 2) {
			Touch a = Input.GetTouch (0);
			Touch b = Input.GetTouch (1);
			Vector2 prevA = (a.position - a.deltaPosition);
			Vector2 prevB = (b.position - b.deltaPosition);
			float delta = (prevA - prevB).magnitude - (a.position - b.position).magnitude;
			if(Mathf.Abs(delta)>5)
				Camera.main.fieldOfView = Mathf.Min(Mathf.Max(Camera.main.fieldOfView + delta,30),120);

			Vector2 DeltaA = (a.position - prevA);
			Vector2 DeltaB = (b.position - prevB);

			Dot = Vector2.Dot (DeltaA, DeltaB);
			if(Dot>20){
				Vector2 mov = (DeltaA + DeltaB) / 2;
				Camera.main.transform.Translate (mov.x, 0, 0);
			}

		}
	}


}
