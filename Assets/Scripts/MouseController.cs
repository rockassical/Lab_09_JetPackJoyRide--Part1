using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour {

	public float jetpackForce = 75.0f;
	//add
	Rigidbody2D rbody;

	void FixedUpdate () 
	{
		bool jetpackActive = Input.GetButton("Fire1");
		
		if (jetpackActive)
		{
			//remove
			//rigidbody2D.AddForce(new Vector2(0, jetpackForce));
			//replace with
			rbody=GetComponent<Rigidbody2D>();
			rbody.AddForce( new Vector2(0, jetpackForce));
		}
	}
}
