﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f,1.5f,0f));// タイトルの回転

        if(Input.GetKeyDown(KeyCode.Space)) SceneManager.LoadScene("main");
    }
}
