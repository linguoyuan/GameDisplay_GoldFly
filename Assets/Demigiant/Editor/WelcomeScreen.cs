using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class Appload
{
    static Appload()
    {
        bool hasKey = PlayerPrefs.HasKey("sikiwelcomescreen");
        if (hasKey==false)
        {
            //EditorApplication.update += Update;
            //PlayerPrefs.SetInt("sikiwelcomescreen", 1);
            //WelcomeScreen.ShowWindow();
        }
    }
}

public class WelcomeScreen : EditorWindow
{
#if false
    private Texture mSamplesImage;
    private Rect imageRect = new Rect(30f, 90f, 350f, 350f);
    private Rect textRect = new Rect(15f, 15f, 380f, 100f);

    public void OnEnable()
    {
        this.mSamplesImage = LoadTexture("wechat.jpg");
    }

    
    Texture LoadTexture(string name)
    {
        string path = "Assets/Demigiant/Editor/";
        return (Texture)AssetDatabase.LoadAssetAtPath(path + name, typeof(Texture));
    }

    public void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = 14;
        style.normal.textColor = Color.white;
        GUI.Label(this.textRect, "欢迎",style);
        GUI.DrawTexture(this.imageRect, this.mSamplesImage);
    }
    
    public static void ShowWindow()
    {
        WelcomeScreen window = EditorWindow.GetWindow<WelcomeScreen>(true, "Hello 你好 ");
        window.minSize = window.maxSize = new Vector2(410f, 470f);
        UnityEngine.Object.DontDestroyOnLoad(window);
    }
#endif
}


