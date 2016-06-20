using UnityEngine;
using System.Collections;

public class GeGomi : MonoBehaviour {

    public float speed = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 rotating = new Vector3(0.0f, 0.0f, -1.0f * speed * Time.deltaTime);
        gameObject.transform.Rotate(rotating);
	}
}