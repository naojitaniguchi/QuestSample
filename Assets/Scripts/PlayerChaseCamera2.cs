using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChaseCamera2 : MonoBehaviour {
    public GameObject player;
    public float xMax = 3.0f;
    public float xMin = -3.0f;
    public float yMax = 3.0f;
    public float yMin = -3.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);

        if (gameObject.transform.position.x > xMax ){
            gameObject.transform.position = new Vector3(xMax, player.transform.position.y, transform.position.z);
        }
        if (gameObject.transform.position.x < xMin)
        {
            gameObject.transform.position = new Vector3(xMin, player.transform.position.y, transform.position.z);
        }
        if (gameObject.transform.position.y > yMax)
        {
            gameObject.transform.position = new Vector3(player.transform.position.x, yMax, transform.position.z);
        }
        if (gameObject.transform.position.y < yMin)
        {
            gameObject.transform.position = new Vector3(player.transform.position.x, yMin, transform.position.z);
        }

    }
}
