using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class Projectile : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rigidbody;

    public event UnityAction<EnemyMover, Projectile> Collision;

    private void Update()
    {
        _rigidbody.velocity = transform.right * _speed;
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    EnemyMover enemy;

    //    if(enemy = collision.GetComponent<EnemyMover>())
    //        Collision?.Invoke(enemy, this);
    //}
}
