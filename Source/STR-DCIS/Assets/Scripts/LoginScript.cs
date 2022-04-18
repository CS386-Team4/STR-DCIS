using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Net;
using System.Text;
using System.Net.Http;

public class LoginScript : MonoBehaviour
{
    public Button submitBtn;
    public Button createBtn;

    public InputField usernameInput;
    public InputField passwordInput;
    public GameObject textDisplay;

    public void Start()
    {
        submitBtn.onClick.AddListener(submit);
        createBtn.onClick.AddListener(create);
    }

    public void StoreUsername()
    {
        //username = usernameInput.GetComponent<Text>().text;
        //password = passwordInput.GetComponent<Text>().text;
        //Debug.Log(username);
        //Debug.Log(password);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void submit()
    {
        using (var client = new WebClient())
        {     
            var values = new NameValueCollection();
            values["user"] = usernameInput.text;
            values["pw"] = passwordInput.text;

            var response = client.UploadValues("http://184.72.195.191/login", values);

            var responseString = Encoding.Default.GetString(response);

            if(responseString[0] == 'y')
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
            else
            {
               usernameInput.text = "retry";
                passwordInput.text = "";
            }
        }
    }

    public void create()
    {
        using (var client = new WebClient())
        {     
            var values = new NameValueCollection();
            values["user"] = usernameInput.text;
            values["pw"] = passwordInput.text;

            var response = client.UploadValues("http://184.72.195.191/create", values);

            var responseString = Encoding.Default.GetString(response);
        }
    }
}
