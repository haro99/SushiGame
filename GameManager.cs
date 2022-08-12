using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Neta
{
    none,
    maguro,
    ika,
    samon,
    onigiri
}
public enum Mode
{
    Play,
    End
}
public class GameManager : MonoBehaviour
{
    public GameObject[] Sushies;    //寿司ネタ
    public GameObject EndObject;
    public Text Total;
    public Vector3 SetPosition;     //配置する位置
    public float count;             //経過時間
    public int totalmoney;
    public int[] status;            //ステータス
    public Slider[] Bars;           //ステータス表示バー
    public Mode mode;               //ゲーム状態
    public bool end;

    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        if (mode == Mode.Play)
        {
            //経過時間が５秒場なら
            if (count > 5f)
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
    }

    /// <summary>
    /// 食べた処理
    /// </summary>
    /// <param name="price"></param>
    public void MoneyAdd(int price, int[] data)
    {
        for(int i = 0; i<data.Length;i++)
        {
            status[i] += data[i];
        }

        MeterUpdate();
        totalmoney += price;
        if (end)
            GameEnd();

    }

    /// <summary>
    /// ステータスの更新
    /// </summary>
    public void MeterUpdate()
    {
        for(int i = 0; i < status.Length;i++)
        {
            Bars[i].value = status[i];
            if (status[i] >= 100)
                end = true;
        }
    }
    public void GameEnd()
    {
        mode = Mode.End;
        EndObject.SetActive(true);
    }
}
