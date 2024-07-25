using UnityEngine;

public class TimeChanger : MonoBehaviour
{
    [SerializeField] private float _standardTime;

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Play()
    {
        Time.timeScale = _standardTime;
    }
}
