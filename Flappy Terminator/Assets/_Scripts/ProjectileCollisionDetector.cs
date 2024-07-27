using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class ProjectileCollisionDetector : MonoBehaviour
{
    public event UnityAction<Enemy, ProjectileCollisionDetector> Collision;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy;

        if (enemy = collision.GetComponent<Enemy>())
        {
            Collision?.Invoke(enemy, this);
        }
    }
}
