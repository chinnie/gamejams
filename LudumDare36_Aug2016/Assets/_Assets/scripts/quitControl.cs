using UnityEngine;
using System.Collections;

public class quitControl : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();

    }
}