using UnityEngine;

public class EnemySpawner : Spawner<Enemy>
{
    [SerializeField] private EnemyProjectileSpawner _projectileSpawner;

    public override void OnGet(Enemy enemy)
    {
        enemy.Fire += Shoot;
        enemy.transform.position = GetRandomPosition();
        base.OnGet(enemy);
    }

    public override void OnRelease(Enemy enemy)
    {
        enemy.Fire -= Shoot;
        base.OnRelease(enemy);
    }

    public void Shoot(Transform firePoint)
    {
        _projectileSpawner.GetObjectFromPool(firePoint.transform);
    }
}
