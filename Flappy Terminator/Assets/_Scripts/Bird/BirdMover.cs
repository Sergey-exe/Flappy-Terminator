using UnityEngine;

public class BirdMover : Mover
{
    [SerializeField] private InputReader _inputReader;

    public override void Move()
    {
        if (_inputReader.DownButtonUpBird())
        {
            Jump();
        }
    }
}
