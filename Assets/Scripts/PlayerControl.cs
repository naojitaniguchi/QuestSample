using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour {
    public float moveSpeed;
    Animator anim;
    Rigidbody2D r2d;
    public GameObject flowObject;

    // Use this for initialization
    void Start()
    {

        if (ScenePosition.positionTable != null)
        {
            if ( ScenePosition.positionTable[SceneManager.GetActiveScene().name] != null){
                Debug.Log(ScenePosition.positionTable[SceneManager.GetActiveScene().name]);
                Vector3 pos = (Vector3)ScenePosition.positionTable[SceneManager.GetActiveScene().name];
                gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z);
            }
        }
    
        anim = gameObject.GetComponent<Animator>();
        r2d = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        r2d.velocity = Vector2.zero;

        if ( Input.GetKey(KeyCode.UpArrow)){
            anim.SetBool("Idle", false);
            anim.SetBool("Up", true);
            r2d.velocity = Vector2.up * moveSpeed;
        }
        else{
            anim.SetBool("Up", false);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("Idle", false);
            anim.SetBool("Down", true);
            r2d.velocity = Vector2.down * moveSpeed;
        }
        else
        {
            anim.SetBool("Down", false);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Idle", false);
            anim.SetBool("Right", true);
            r2d.velocity = Vector2.right * moveSpeed;
        }
        else
        {
            anim.SetBool("Right", false);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("Idle", false);
            anim.SetBool("Left", true);
            r2d.velocity = Vector2.left * moveSpeed;
        }
        else
        {
            anim.SetBool("Left", false);
        }
        if ( Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) ||
            Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) ){
            anim.SetBool("Idle", true);
        }

        if ( Input.GetKeyDown( KeyCode.A)){
            ScenePosition.AddScenePos(SceneManager.GetActiveScene().name, gameObject.transform.position);
            SceneManager.LoadScene("Scenes/Stage2");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            SceneManager.LoadScene("lecture/CallFungusSmaple");
        }
        if (Input.GetKeyDown(KeyCode.Z)){
            flowObject.SetActive(true);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            // シーン名を取得
            string sceneName = collision.gameObject.GetComponent<Door>().nextScene;
            // シーンチェンジ
            SceneManager.LoadScene(sceneName);
        }
        if (collision.gameObject.tag == "Talk")
        {
            // Fungusを呼ぶ
            collision.gameObject.GetComponent<Talk>().startTalk();
        }
    }
}
