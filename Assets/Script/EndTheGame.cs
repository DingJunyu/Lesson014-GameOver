using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTheGame : MonoBehaviour
{
    private bool GameEndMark = false;
    public bool ReferGameEnd() { return GameEndMark; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            GameEndMark = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
