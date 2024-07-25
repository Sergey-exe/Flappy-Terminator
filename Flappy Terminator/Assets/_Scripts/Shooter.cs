using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private PlayerProjectileSpawner _spawner;
    [SerializeField] private InputReader _inputReader;
    [SerializeField] private bool _botShoot;

    private void Update()
    {
        if(_botShoot == false)
            if (_inputReader.DownButtonSoot())
                Shoot();
    }

    public void Shoot()
    {
        _spawner.GetObjectFromPool(transform);
    }
}
