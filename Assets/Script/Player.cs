using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float Speed = 30;
    private float dropSpeed = 0.0025f;
    Rigidbody Rg;
    private bool dead;
    public void SetDeath() { dead = true; }

    private Vector3 TargetVector = new Vector3();
    public void SetTarVec(Vector3 vec) { TargetVector = vec; }

    // Start is called before the first frame update
    void Start()
    {
        dead = false;
        Rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // 入力
        InputControll();
        if (dead && transform.position.y > -5f) {
            Vector3 vector3 = transform.position;
            Vector3 down = new Vector3( 0, dropSpeed, 0 );
            dropSpeed += 0.0025f;
            vector3 -= down;
            TargetVector.y = transform.position.y;

            Rg.transform.SetPositionAndRotation(vector3,
                transform.rotation);//下に落ちる
            transform.position = Vector3.MoveTowards(transform.position, TargetVector, Time.deltaTime * 1f);
        }
        if (transform.position.y < -2f && !dead) {
            GameObject.Find("GameRoot").GetComponent<Root>().SetGameOver();
        }
    }

    void InputControll()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Rg.AddForce(new Vector3(0f, 0f, Speed));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Rg.AddForce(new Vector3(0f, 0f, -Speed));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Rg.AddForce(new Vector3(Speed, 0f, 0f));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rg.AddForce(new Vector3(-Speed, 0f, 0f));
        }

    }
}
