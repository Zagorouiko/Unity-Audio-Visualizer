using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerper : MonoBehaviour {

    public float speed = .1f;

    private Vector3 start;
    private Vector3 des;
    private float fraction = 0;

    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	    transform.position = new Vector3(Mathf.PingPong(Time.time, 3), transform.position.y, transform.position.z);
    }
}
