using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempItemPlacement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void pressed()
    {
        GameObject objPlaced = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        objPlaced.transform.position = this.transform.position;
        Instantiate(objPlaced);
    }
    public void cube()
    {
        GameObject objPlaced = GameObject.CreatePrimitive(PrimitiveType.Cube);
        objPlaced.transform.position = this.transform.position;
        Instantiate(objPlaced);
    }
    public void capsule()
    {
        GameObject objPlaced = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        objPlaced.transform.position = this.transform.position;
        Instantiate(objPlaced);
    }
    public void plane()
    {
        GameObject objPlaced = GameObject.CreatePrimitive(PrimitiveType.Plane);
        objPlaced.transform.position = this.transform.position;
        Instantiate(objPlaced);
    }
    public void cylinder()
    {
        GameObject objPlaced = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        objPlaced.transform.position = this.transform.position;
        Instantiate(objPlaced);
    }
}
