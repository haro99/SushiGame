using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuthiScript : MonoBehaviour
{
    public GameManager GameManager; //�Q�[���}�l�[�W���[
    public Vector3 movespeed;       //�X�s�[�h
    public int price;               //���i�̒l�i
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //�������ړ�������
        transform.position += movespeed * Time.deltaTime;

        
        if (transform.position.x < -10)
            Destroy(gameObject);
    }

    /// <summary>
    /// �N���b�N���ꂽ��
    /// </summary>
    private void OnMouseDown()
    {
        Debug.Log("���܂���");
        this.GameManager.MoneyAdd(price);
        Destroy(gameObject);        //���̃I�u�W�F�N�g���폜����
    }
}
