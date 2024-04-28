using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseShow : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private int MaxDeadCount;
    private void Start()
    {
        IsShow();
        Yandex.Instance.deadCount += 1;
        if (Yandex.Instance.deadCount == MaxDeadCount)
        {
            Yandex.Instance.isShow = true;
        }
    }
    public void IsShow()
    {
        if (Yandex.Instance.isShow == true)
        {
            Yandex.Instance.isShow = false;
            Yandex.Instance.deadCount = 0;
            StartCoroutine(PauseShowScript());
        }
        IEnumerator PauseShowScript()
        {
            pausePanel.SetActive(true);
            Yandex.Instance.ShowPlay();
            yield return new WaitForSeconds(1);
            Debug.Log("реклама закончена");
            pausePanel.SetActive(false);
        }

    }
}
