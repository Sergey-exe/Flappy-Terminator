using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private BirdCollisionHandler _collisionHandler;
    [SerializeField] private EnemySpawner _enemySpawner;
    [SerializeField] private PlayerProjectileSpawner _projectileSpawner;
    [SerializeField] private TimeChanger _timeChanger;
    [SerializeField] private StartScreen _startScreen;
    [SerializeField] private EndGameScreen _endScreen;

    private void Awake()
    {
        _timeChanger.Pause();
    }

    private void OnEnable()
    {
        _collisionHandler.Collision += OverGame;
        _startScreen.PlayButtonClicked += PlayGame;
        _endScreen.RestartButtonClicked += RestartGame;
    }

    private void OnDisable()
    {
        _collisionHandler.Collision -= OverGame;
        _startScreen.PlayButtonClicked -= PlayGame;
        _endScreen.RestartButtonClicked -= RestartGame;
    }

    public void PlayGame()
    {
        _timeChanger.Play();
        _startScreen.Close();
    }

    private void OverGame()
    {
        _timeChanger.Pause();
        _endScreen.Open();
    }

    private void RestartGame()
    {
        PlayGame();
        _endScreen.Close();
        _enemySpawner.Restart();
        _projectileSpawner.Restart();
        _bird.Restart();
    }
}
