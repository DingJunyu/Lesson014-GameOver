using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // シーンジャンプするときはこれが必要
using System;   // DateTimeクラスに必要

public class Root : MonoBehaviour
{
    public GameObject FlagPref; // フラッグのプレハブ

    public UnityEngine.UI.Text RemainText;  // GUIフラッグ数テキスト
    public UnityEngine.UI.Text ClearText;  // GUIクリアテキスト
    public UnityEngine.UI.Text ClearMess;   // GUIクリア時の入力メッセージ
    public UnityEngine.UI.Text RemainTimeText;  // GUI経過時間テキスト

    public int FlagNum = 10; // フラッグの数

    DateTime StartTime; // 開始時の時間を取っておく
    public static TimeSpan Sp;    // 経過時間

    private bool GameOver { get; set; }
    public void SetGameOver() { GameOver = true; }
    

    // Start is called before the first frame update
    void Start()
    {
        GameOver = false;
        ClearText.enabled = false;  // クリアメッセージは非表示にしておく
        ClearMess.enabled = false;

        StartTime = DateTime.Now;   // 現在時刻を記録
    }

    // Update is called once per frame
    void Update()
    {
        string tmp = "";
        RemainText.text = tmp;

        // クリアメッセージ
        if (GameObject.Find("EndMark").GetComponent<EndTheGame>().ReferGameEnd())   // フラグがなくなったら
        {
            ClearText.enabled = true;   // クリアメッセージ表示
            ClearMess.enabled = true;
        }

        if (GameOver&&!ClearText.enabled) {//ゲームオーバーの時に一回だけを呼び出す
            GameObject.FindGameObjectWithTag("Player").GetComponent<Collider>().enabled = false;//プレーヤーのcolliderを無効にする
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().SetDeath();//プレーヤーの状態を死亡に設置する
            GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().isKinematic = true;//物理演算を無効にする

            ClearText.text = "GameOver";
            ClearText.fontSize = 90;
            ClearText.enabled = true;
            ClearMess.enabled = true;
        }

        // クリア時の処理
        if (ClearText.enabled && Input.GetKeyUp(KeyCode.Space))
        {
            // resultシーンへ
            if (!GameOver)
                SceneManager.LoadScene("result");
            else
                SceneManager.LoadScene("Title");
        }

        // 経過時間
        if (!ClearText.enabled) // プレイ中のみ処理する
        {
            Sp = DateTime.Now - StartTime;  // 経過時間を計算
            RemainTimeText.text = Sp.ToString(); // 表示位置にテキストとして出力
        }
    }

}
