using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Iinteracte
{
    public void Interectable();
}

public class playerActoin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Iinteracte interacte)) interacte.Interectable();
    }
}
