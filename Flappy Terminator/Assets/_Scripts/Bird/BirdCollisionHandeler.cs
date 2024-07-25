using UnityEngine;
using UnityEngine.Events;

public class BirdCollisionHandler : MonoBehaviour 
{
    public event UnityAction Collision;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Obstruction>())
            Collision?.Invoke();
    }
}
