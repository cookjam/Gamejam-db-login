using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Cookapps.Auth;

public class AuthExampleMain : MonoBehaviour {

    public Button googleplayLoginBtn;
    public Button googleplayLogoutBtn;

    void Start()
    {
        this.googleplayLoginBtn.onClick.AddListener(this.onClickGoogleplayLogin);
        this.googleplayLogoutBtn.onClick.AddListener(this.onClickGoogleplayLogout);
    }

    void onClickGoogleplayLogin() {
        AuthManager.LoginWithGooglePlay();
    }

    void onClickGoogleplayLogout() {

    }

}