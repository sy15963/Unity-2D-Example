using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {

            SoundManager.Instance.Sound();
            transform.position += new Vector3(0, 0, 1);
        }

    }
}
