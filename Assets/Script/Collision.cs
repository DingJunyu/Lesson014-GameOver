using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        var name = collision.name;
        if (name == "Player") {
            GameObject.Find("GameRoot").GetComponent<Root>().SetGameOver();
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().SetTarVec(this.transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
