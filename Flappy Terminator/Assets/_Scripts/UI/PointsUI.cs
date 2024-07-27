using TMPro;
using UnityEngine;

public class PointsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] protected PointsCounter _counter;

    private void OnEnable()
    {
        _counter.ChangePoints += ChangeText;
    }

    private void OnDisable()
    {
        _counter.ChangePoints -= ChangeText;
    }

    private void ChangeText(int count)
    {
        _text.text = count.ToString();
    }
}
