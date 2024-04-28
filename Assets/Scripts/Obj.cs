using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class Obj : MonoBehaviour, Iinteracte
{
   private enum TypeObj
    {
        Coin,Enemy
    }

    [SerializeField] private TypeObj typeObj;
    [SerializeField] private float speed;
    [SerializeField] private string SceneName;

    public void Interectable()
    {
        switch (typeObj)
        {
            case TypeObj.Coin:
                Debug.Log("Coin");
                Coin();
                break;
            case TypeObj.Enemy:
                Debug.Log("Enemy");
                Restart();
                break;
        }
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
        if(transform.position.y == -10) Destroy(gameObject);
    }

    private void Restart()
    {
        StartCoroutine(RestartCor());
        IEnumerator RestartCor()
        {
            AsyncOperation async = SceneManager.LoadSceneAsync(SceneName);
            yield return new WaitForSeconds(0);
        }
    }
    private void Coin()
    {
        Score.Instance.AddScore();
    }
}
