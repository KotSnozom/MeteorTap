using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yandex : MonoBehaviour
{
    public static Yandex Instance;
    public int deadCount;
    public bool isShow = true;

    [DllImport("__Internal")]
    private static extern void ShowAds();

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else Destroy(gameObject);
    }
    public void ShowPlay()
    {
        Debug.Log("реклама");
        ShowAds();
    }
}
