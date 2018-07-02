using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPart : MonoBehaviour {

    public int excersiseFatigueCost = 10;

    int fatigue = 0;

    [SerializeField] private ObjectShake shaker;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
    {

    }

    void OnMouseDown()
    {
        fatigue += excersiseFatigueCost;
        shaker.ShakeObject();
        print("CLICKED");
    }
}

