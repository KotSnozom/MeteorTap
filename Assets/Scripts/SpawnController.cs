using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private List<GameObject> _defObj = new List<GameObject>();
    [SerializeField] private Transform _spawnObj,EndPos;
    [SerializeField] private float _speed, MinTime,MaxTime;

    private void Start()
    {
        SpannerEnemyToCoin();
    }
    private void SpannerEnemyToCoin()
    {
        int randObj;
        Vector2 randPos;
        StartCoroutine(Spawns());

        IEnumerator Spawns()
        {
            while (true)
            {
                var _wait = new WaitForSeconds(UnityEngine.Random.Range(MinTime, MaxTime));
                yield return _wait;

                randObj = UnityEngine.Random.Range(0, _defObj.Count);
                randPos = new Vector2(UnityEngine.Random.Range(-2.5f,2.5f), _spawnObj.position.y);

                Rigidbody2D newObj = Instantiate(_defObj[randObj], randPos, Quaternion.identity).GetComponent<Rigidbody2D>();
                Vector2 NewEndDir = new Vector2(UnityEngine.Random.Range(-2f,2f),EndPos.position.y);

                newObj.velocity = (NewEndDir - newObj.position) * _speed * Time.deltaTime;
            }
        }
    }
}
