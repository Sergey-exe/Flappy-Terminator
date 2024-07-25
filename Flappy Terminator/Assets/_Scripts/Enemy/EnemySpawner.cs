public class EnemySpawner : Spawner<EnemyMover>
{
    public override void ActionOnGet(EnemyMover enemy)
    {
        enemy.transform.position = GetRandomPosition();
        base.ActionOnGet(enemy);
    }
}
