using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public GameObject Parent;
    public AnimationCurve TimingCurve;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("time: " + Time.time + " - eval: " + TimingCurve.Evaluate(Time.time));
	    transform.RotateAround(Parent.transform.position, Vector3.up, TimingCurve.Evaluate(Time.time) * Time.deltaTime);
    }
}
