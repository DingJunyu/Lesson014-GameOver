using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMessage : MonoBehaviour
{
    int Cnt = 0;

    MeshRenderer MyRend;    // レンダー

    // Start is called before the first frame update
    void Start()
    {
        MyRend = GetComponent<MeshRenderer>();  // メッシュレンダラのコンポーネントを得る
    }

    // Update is called once per frame
    void Update()
    {
        Cnt++;  // フレームカウンタ
        MyRend.enabled = (Cnt % 50 < 30);   // ブリンク
    }
}
