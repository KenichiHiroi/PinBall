using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    //���_��\������e�L�X�g
    private GameObject totalPointText;

    //���݂̑����_
    private int totalPoint = 0;

    //�������I�u�W�F�N�g�̐ڐG���_
    private int smallObjectPoint = 10;

    //�傫���I�u�W�F�N�g�̐ڐG���_
    private int largeObjectPoint = 20;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[�����̃I�u�W�F�N�g�擾
        this.totalPointText = GameObject.Find("TotalPointText");

        //�e�L�X�g�I�u�W�F�N�g�ɏ����l��0�_��\��
        this.totalPointText.GetComponent<Text> ().text = "Point:0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //
    private void OnCollisionEnter(Collision collision)
    {
        //�ڐG�����I�u�W�F�N�g���擾���A���ꂼ��ɉ��������_�����Z����
        if(collision.gameObject.tag == "SmallStarTag" || collision.gameObject.tag == "SmallCloudTag")
        {
            //���݂̑����_�ɏ������I�u�W�F�N�g�̐ڐG���_�����Z
            totalPoint += smallObjectPoint;
            //�����_�̃e�L�X�g�I�u�W�F�N�g�̕\�����X�V
            this.totalPointText.GetComponent<Text>().text = "Point:" + totalPoint.ToString();
        }
        else if(collision.gameObject.tag == "LargeStarTag" || collision.gameObject.tag == "LargeCloudTag")
        {
            //���݂̑����_�ɑ傫���I�u�W�F�N�g�̐ڐG���_�����Z
            totalPoint += largeObjectPoint;
            //�����_�̃e�L�X�g�I�u�W�F�N�g�̕\�����X�V
            this.totalPointText.GetComponent<Text>().text = "Point:" + totalPoint.ToString();
        }
    }
}
