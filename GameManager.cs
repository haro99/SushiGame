using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] Sushies;    //寿司ネタ
    public Text Total;
    public Vector3 SetPosition;     //配置する位置
    public float count;             //経過時間
    public int totalmoney;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //経過時間が５秒場なら
        if(count>5f)
        {
            //寿司を配置
            Instantiate(Sushies[Random.Range(0, Sushies.Length)], SetPosition, Quaternion.identity);
            Debug.Log("寿司を配置しました");
            count = 0f;     //カウントをリセット
        }
        else
        {
            //カウントに時間を追加
            count += Time.deltaTime;
        }

        Total.text = "食べた合計 " + totalmoney + "円";
    }

    /// <summary>
    /// 食べた値段を合計に追加
    /// </summary>
    /// <param name="price"></param>
    public void MoneyAdd(int price)
    {
        totalmoney += price;
    }

}
