using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

namespace Cookapps.Auth {

public class AuthManager : MonoBehaviour {

    public static AuthManager Instance;

    private System.Action<string> onAuthCallback;

    void Awake() {
        DontDestroyOnLoad(this.gameObject);
		if (Instance) return;
		Instance = this;
        
    }
	void Start () {
		PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder()
                    .RequestIdToken()
                    .RequestServerAuthCode(false)
                    .Build();

        PlayGamesPlatform.InitializeInstance(config);
        // recommended for debugging:
        PlayGamesPlatform.DebugLogEnabled = true;
        // Activate the Google Play Games platform
        PlayGamesPlatform.Activate();
	}
    
    void loginWithGooglePlay(System.Action<string> callback = null) {
        this.onAuthCallback = callback;
        Social.localUser.Authenticate(this.onComplete);
    }

    void onComplete(bool success, string message) {
        if (success == false) {
            // 파베 게스트 로그인 
        } else {
            // 
        }
    }

    public static void LoginWithGooglePlay(System.Action<string> callback = null) {
        Instance.loginWithGooglePlay(callback);
    }

}
}