using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public static Manager manager = null;
    public bool turn = true; //X is first
    public char[,] board = new char[3,3];

    void Awake()
    {
        if (manager == null)
        {
            manager = this;
        }
        else if(manager != this)
        {
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
