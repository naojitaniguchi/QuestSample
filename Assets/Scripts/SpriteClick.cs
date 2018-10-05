using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class SpriteClick : MonoBehaviour, IPointerClickHandler
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //メソッド実装
    public void OnPointerClick(PointerEventData eventData)
    {
        //ここにクリックしたときの処理
        Debug.Log(eventData);
    }
}
