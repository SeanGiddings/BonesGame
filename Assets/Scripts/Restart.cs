using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Destroy(GameManager.instance.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}