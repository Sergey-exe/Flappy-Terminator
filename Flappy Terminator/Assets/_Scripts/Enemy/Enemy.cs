using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : Mover
{
    [SerializeField] private float _jumpDelay;
    [SerializeField] private Transform _firePoint;

    private Coroutine _coroutine;

    public event UnityAction<Transform> Fire;

    private void OnDisable()
    {
        _coroutine = null;
    }

    public override void Move()
    {
        if (_coroutine == null)
            _coroutine = StartCoroutine(JumpAfterDelay());
    }

    private IEnumerator JumpAfterDelay()
    {
        WaitForSeconds wait = new WaitForSeconds(_jumpDelay);

        Jump();
        Fire?.Invoke(_firePoint);

        yield return wait;

        _coroutine = null;
    }
}
