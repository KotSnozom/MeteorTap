using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private List<Transform> _dirPos = new List<Transform>();
    [SerializeField] private float _speed;
    [SerializeField, Min(0)] private int _index;

    private void Update()
    {
        Move();
        if(Input.GetMouseButtonDown(0))NewDirection();
    }

    #region Move
    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _dirPos[_index].position,_speed * Time.deltaTime);
        if (transform.position == _dirPos[_index].position) NewDirection();
    }
    private void NewDirection()
    {
        _index = (_index + 1) % _dirPos.Count;
    }
    #endregion
}
