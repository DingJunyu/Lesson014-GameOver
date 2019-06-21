using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))   // 当たった相手がプレイヤーだったら
        {
            Destroy(gameObject);    // 自分は消える
        }       
    }
}
