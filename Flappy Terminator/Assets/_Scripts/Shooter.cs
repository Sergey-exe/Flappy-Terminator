using System.Collections;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private float _delay;
    [SerializeField] private PlayerProjectileSpawner _spawner;
    [SerializeField] private InputReader _inputReader;

    private Coroutine _coroutine;

    private void Update()
    {
        if (_inputReader.DownButtonSoot())
            if (_coroutine == null)
                _coroutine = StartCoroutine(ShootWithDelay());
    }

    public void Shoot()
    {
        _spawner.GetObjectFromPool(transform);
    }

    private IEnumerator ShootWithDelay()
    {
        WaitForSeconds wait = new WaitForSeconds(_delay);

        Shoot();

        yield return wait;

        _coroutine = null;
    }
}