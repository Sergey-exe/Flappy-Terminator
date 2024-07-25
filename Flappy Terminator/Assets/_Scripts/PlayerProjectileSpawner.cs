using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectileSpawner : Spawner<Projectile>
{
    [SerializeField] private ProjectileDestroyer _destroyer;
    [SerializeField] private EnemyDestroyer _enemyDestroyer;
    [SerializeField] private EnemySpawner _enemySpawner;

    public override void ActionOnGet(Projectile spawnObject)
    {
        spawnObject.Collision += ReleaseEnemy;
        base.ActionOnGet(spawnObject);
    }

    public override void Release(Projectile spawnObject)
    {
        spawnObject.Collision -= ReleaseEnemy;
        base.Release(spawnObject);
    }

    private void ReleaseEnemy(EnemyMover enemy, Projectile projectile)
    {
        Release(projectile);
        _enemySpawner.Release(enemy);
    }
}
