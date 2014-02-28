using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {

	float speed =5.0f;

	Vector3 movePosition;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetAxis("Horizontal")!=0){

			movePosition.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
			transform.position = movePosition;
		}

		if(Input.GetAxis("Vertical")!=0){
			
			movePosition.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
			transform.position = movePosition;
		}
	}
}
