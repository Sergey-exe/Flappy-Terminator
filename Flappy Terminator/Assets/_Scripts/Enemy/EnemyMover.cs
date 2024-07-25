using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class EnemyMover : Mover
{
    [SerializeField] private float _jumpDelay;

    private Coroutine _coroutine;

    private event UnityAction IsJump;

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
        IsJump?.Invoke();

        yield return wait;

        _coroutine = null;
    }
}
