using UnityEngine;

[RequireComponent(typeof(BirdMover))]
public class Bird : MonoBehaviour
{
    [SerializeField] private BirdMover _birdMover;

    public void Restart()
    {
        _birdMover.Restart();
    }
}
