using UnityEngine;
using UnityEngine.Events;

public class PlayerProjectileSpawner : Spawner<ProjectileCollisionDetector>
{
    [SerializeField] private ProjectileDestroyer _destroyer;
    [SerializeField] private EnemyDestroyer _enemyDestroyer;
    [SerializeField] private EnemySpawner _enemySpawner;

    public event UnityAction HitEnemy;

    public override void OnGet(ProjectileCollisionDetector projectile)
    {
        projectile.Collision += ReleaseOnCollision;
        base.OnGet(projectile);
    }

    public override void OnRelease(ProjectileCollisionDetector projectile)
    {
        projectile.Collision -= ReleaseOnCollision;
        base.OnRelease(projectile);
    }

    private void ReleaseOnCollision(Enemy enemy, ProjectileCollisionDetector projectile)
    {
        Release(projectile);
        _enemySpawner.Release(enemy);
        HitEnemy?.Invoke();
    }
}
