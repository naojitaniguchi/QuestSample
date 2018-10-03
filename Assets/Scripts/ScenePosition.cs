using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScenePosition : MonoBehaviour {
    public static Hashtable positionTable;

    // Use this for initialization
    void Start () {
        positionTable = new Hashtable();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void AddScenePos( string ScnenName, Vector3 pos){
        positionTable.Add(ScnenName, pos);
    }
}
