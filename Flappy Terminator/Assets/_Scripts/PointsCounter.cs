using UnityEngine;
using UnityEngine.Events;

public class PointsCounter : MonoBehaviour
{
    [SerializeField] private int _points;
    [SerializeField] private PlayerProjectileSpawner _projectileSpawner;

    public event UnityAction<int> ChangePoints;

    private void OnEnable()
    {
        _projectileSpawner.HitEnemy += AddPoints;
    }

    private void OnDisable()
    {
        _projectileSpawner.HitEnemy -= AddPoints;
    }

    public void Restart()
    {
        _points = 0;
        ChangePoints?.Invoke(_points);
    }

    private void AddPoints()
    {
        _points++;
        ChangePoints?.Invoke(_points);
    }
}
