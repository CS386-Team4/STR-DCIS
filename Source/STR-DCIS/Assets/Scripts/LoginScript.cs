using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginScript : MonoBehaviour
{
    public string username;
    public string password;

    public GameObject usernameInput;
    public GameObject passwordInput;
    public GameObject textDisplay;

    public void StoreUsername()
    {
        username = usernameInput.GetComponent<Text>().text;
        password = passwordInput.GetComponent<Text>().text;
        Debug.Log(username);
        Debug.Log(password);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
