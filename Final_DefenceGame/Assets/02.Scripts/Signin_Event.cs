using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class Signin_Event : MonoBehaviour
{
    public Button SigninButton;
    public Button SignupButton;

    private UnityAction signinaction;
    private UnityAction signupaction;

    void Start()
    {
        signupaction = () => OnSignupClick();
        SignupButton.onClick.AddListener(signupaction);

    }

   
    public void OnSignupClick()
    {
        SceneManager.LoadScene("Signup_Scene");
    }
}
