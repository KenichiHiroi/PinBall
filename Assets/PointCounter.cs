using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    //得点を表示するテキスト
    private GameObject totalPointText;

    //現在の総得点
    private int totalPoint = 0;

    //小さいオブジェクトの接触得点
    private int smallObjectPoint = 10;

    //大きいオブジェクトの接触得点
    private int largeObjectPoint = 20;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のオブジェクト取得
        this.totalPointText = GameObject.Find("TotalPointText");

        //テキストオブジェクトに初期値の0点を表示
        this.totalPointText.GetComponent<Text> ().text = "Point:0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //
    private void OnCollisionEnter(Collision collision)
    {
        //接触したオブジェクトを取得し、それぞれに応じた得点を加算する
        if(collision.gameObject.tag == "SmallStarTag" || collision.gameObject.tag == "SmallCloudTag")
        {
            //現在の総得点に小さいオブジェクトの接触得点を加算
            totalPoint += smallObjectPoint;
            //総得点のテキストオブジェクトの表示を更新
            this.totalPointText.GetComponent<Text>().text = "Point:" + totalPoint.ToString();
        }
        else if(collision.gameObject.tag == "LargeStarTag" || collision.gameObject.tag == "LargeCloudTag")
        {
            //現在の総得点に大きいオブジェクトの接触得点を加算
            totalPoint += largeObjectPoint;
            //総得点のテキストオブジェクトの表示を更新
            this.totalPointText.GetComponent<Text>().text = "Point:" + totalPoint.ToString();
        }
    }
}
