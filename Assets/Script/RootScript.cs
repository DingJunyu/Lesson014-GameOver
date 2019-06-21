using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RootScript : MonoBehaviour
{
    public UnityEngine.UI.Text Txt;

    // Start is called before the first frame update
    void Start()
    {
        Txt.text = Root.Sp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("title");
        }
    }
}
