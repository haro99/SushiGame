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
    public GameObject[] Sushies;    //���i�l�^
    public GameObject EndObject;
    public Text Total;
    public Vector3 SetPosition;     //�z�u����ʒu
    public float count;             //�o�ߎ���
    public int totalmoney;
    public int[] status;            //�X�e�[�^�X
    public Slider[] Bars;           //�X�e�[�^�X�\���o�[
    public Mode mode;               //�Q�[�����
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
            //�o�ߎ��Ԃ��T�b��Ȃ�
            if (count > 5f)
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
    }

    /// <summary>
    /// �H�ׂ�����
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
    /// �X�e�[�^�X�̍X�V
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
