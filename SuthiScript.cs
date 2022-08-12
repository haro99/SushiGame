using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuthiScript : MonoBehaviour
{
    public GameManager GameManager; //ゲームマネージャー
    public Vector3 movespeed;       //スピード
    public int price;               //寿司の値段
    public int[] status;              //食べた時のステータス追加量
    public Neta Netatype;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //少しずつ移動させる
        transform.position += movespeed * Time.deltaTime;

        
        if (transform.position.x < -10)
            Destroy(gameObject);
    }

    /// <summary>
    /// クリックされた時
    /// </summary>
    private void OnMouseDown()
    {
        Debug.Log("取りました");
        this.GameManager.MoneyAdd(price, status);
        Destroy(gameObject);        //このオブジェクトを削除する
    }
}
