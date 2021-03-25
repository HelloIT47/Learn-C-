using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] ships = new GameObject[2];

    void Start()
    {
        int shipIndex = PlayerPrefs.GetInt("shipIndex", 0);
        Instantiate(ships[shipIndex], new Vector3(90f, 1f, 1.5f), Quaternion.identity);
    }
}
