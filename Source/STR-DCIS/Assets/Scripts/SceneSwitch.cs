using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(gameObject.GetComponent<SpriteRenderer>().name);
        if (gameObject.GetComponent<SpriteRenderer>().name == "Exit Doorway")
        {
            SceneManager.LoadScene(5);
        }
        else
        {
            SceneManager.LoadScene(3);
        }
    }
}
