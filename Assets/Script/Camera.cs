using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform Target;    // プレイヤーをフォローする

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // 位置の調整
        transform.position = Target.position + new Vector3(0f, 10f, 0f);

        // 角度の調整
        transform.LookAt(Target);
    }
}
