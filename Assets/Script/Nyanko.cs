using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nyanko : MonoBehaviour
{
    Rigidbody2D Rg;     // Rigidbody2Dの受け皿
    System.Random Rnd;  // 乱数の用意
    int Cnt=0;  // フレームカウンタ

    // Start is called before the first frame update
    void Start()
    {
        Rg = GetComponent<Rigidbody2D>();   // Rigidbody2Dのコンポーネントにアクセス
        Rnd = new System.Random();  // 乱数の用意
    }

    // Update is called once per frame
    void Update()
    {
        if (Cnt % 100 == 0) // 100フレームに一度
        {
            // てきとうな方向へ力を加える
            Rg.AddForce(new Vector2(
                ((float)Rnd.NextDouble() * 2f - 1f)*1000f,
                ((float)Rnd.NextDouble() * 2f - 1f)*1000f
                ));
        }
        Cnt++;  // フレームカウント
    }
}
