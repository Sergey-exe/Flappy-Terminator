using UnityEngine;

public class ProjectileMover : MonoBehaviour 
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rigidbody;

    private void Update()
    {
        _rigidbody.velocity = transform.right * _speed;
    }
}
