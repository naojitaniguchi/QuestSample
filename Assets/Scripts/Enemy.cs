using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public bool alive = true;
    public string[] animType;

	// Use this for initialization
	void Start () {
        StartCoroutine("Attack");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // コルーチン  
    private IEnumerator Attack()
    {
        // コルーチンの処理  
        while( alive ){
            float waitTime = Random.Range(1.0f, 3.0f);
            yield return new WaitForSeconds(waitTime);

            Debug.Log("Attack");

            int animIndex = Random.Range(0, animType.Length);
            Debug.Log(animType[animIndex]);

            // anim.SetBool(animType[animIndex], true);

        }
    }
}


// http://developer.wonderpla.net/entry/blog/engineer/Unity_Co-routine/