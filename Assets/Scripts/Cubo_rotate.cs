using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_rotate : MonoBehaviour {

		public float yaw;
		public float pitch;
		public float roll;
		public float lectura;
		public Vector3 v3To = new Vector3(90,0,0);
        public Vector3 v3Current = new Vector3(0,0,0);
        public float speed = 1.0f;
        
        private float timeCount = 0.0f;
		
	// Use this for initialization
	void Start (){
		transform.eulerAngles = v3Current; 
	}
	
	// Update is called once per frame
	void Update () { 
		//transform.Rotate(Vector3.right*yaw);
		//transform.Rotate(Vector3.up*pitch);
		//lectura=transform.rotation.x;
		v3Current = Vector3.Lerp(v3Current, v3To, Time.deltaTime * speed);
        transform.eulerAngles = v3Current; 
         
		 
	}
}
