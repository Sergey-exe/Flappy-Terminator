using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _tapForce;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _minRotationZ;
    [SerializeField] private float _maxRotationZ;
    [SerializeField] private Rigidbody2D _rigidbody;

    private Vector2 _startPosition;
    private Quaternion _startRotation;
    private Quaternion _maxRotation;
    private Quaternion _minRotation;

    private void Start()
    {
        _startPosition = transform.position;
        _startRotation = transform.rotation;
        _maxRotation = Quaternion.Euler(0, 0, _maxRotationZ);
        _minRotation = Quaternion.Euler(0, 0, _minRotationZ);
    }

    private void Update()
    {
        Move();
        transform.rotation = Quaternion.Lerp(transform.rotation, _minRotation, _rotationSpeed * Time.deltaTime);
    }

    public void Jump()
    {
        _rigidbody.velocity = new Vector2(_speed, _tapForce);
        transform.rotation = _maxRotation;
    }

    public void Restart()
    {
        transform.position = _startPosition;
        transform.rotation = _startRotation;
        _rigidbody.velocity = Vector2.zero;
    }

    public abstract void Move();
}
