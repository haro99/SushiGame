using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] Sushies;    //���i�l�^
    public Text Total;
    public Vector3 SetPosition;     //�z�u����ʒu
    public float count;             //�o�ߎ���
    public int totalmoney;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�o�ߎ��Ԃ��T�b��Ȃ�
        if(count>5f)
        {
            //���i��z�u
            Instantiate(Sushies[Random.Range(0, Sushies.Length)], SetPosition, Quaternion.identity);
            Debug.Log("���i��z�u���܂���");
            count = 0f;     //�J�E���g�����Z�b�g
        }
        else
        {
            //�J�E���g�Ɏ��Ԃ�ǉ�
            count += Time.deltaTime;
        }

        Total.text = "�H�ׂ����v " + totalmoney + "�~";
    }

    /// <summary>
    /// �H�ׂ��l�i�����v�ɒǉ�
    /// </summary>
    /// <param name="price"></param>
    public void MoneyAdd(int price)
    {
        totalmoney += price;
    }

}
