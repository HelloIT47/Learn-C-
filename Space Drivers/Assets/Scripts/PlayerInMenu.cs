using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInMenu : MonoBehaviour
{
    private Transform tr;
    void Start()
    {
        tr = this.gameObject.transform;
    }
    void Update()
    {
        tr.Rotate(Vector3.up, 0.2f);
    }
}
