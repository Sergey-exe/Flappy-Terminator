using UnityEngine;

[RequireComponent(typeof(BirdMover))]
[RequireComponent(typeof(ScoreCounter))]
public class Bird : MonoBehaviour
{
    [SerializeField] private BirdMover _birdMover;
    [SerializeField] private ScoreCounter _scoreCounter;

    public void Restart()
    {
        _birdMover.Restart();
        _scoreCounter.Restart();
    }
}
