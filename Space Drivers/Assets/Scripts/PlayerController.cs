using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public Color32 playerColor;

    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveX();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveBack();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            PlayerRotation(0.2f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            PlayerRotation(-0.2f);
        }

    }
    void ChangeColor()
    {
        player.GetComponent<MeshRenderer>().material.color = playerColor;
    }

    void MoveX()
    {
        player.transform.Translate(new Vector3(-0.5f * playerSpeed, 0, 0));
    }
    void MoveBack()
    {
        player.transform.Translate(new Vector3(0.5f * playerSpeed, 0, 0));
    }
    void PlayerRotation(float value)
    {
        player.transform.Rotate(Vector3.up, playerSpeed * value);
    }
}
