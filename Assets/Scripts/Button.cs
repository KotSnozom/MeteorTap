using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] private string SceneName;
    public void Restart()
    {
        StartCoroutine(RestartCor());
        IEnumerator RestartCor()
        {
            AsyncOperation async = SceneManager.LoadSceneAsync(SceneName);
            yield return new WaitForSeconds(0);
        }
    }
}
