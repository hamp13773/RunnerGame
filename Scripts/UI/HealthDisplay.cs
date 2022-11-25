using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Player _player;

    private TMP_Text _healthDisplay;

    private void Start()
    {
        _healthDisplay = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        _player.OnHealthChanged += OnHealthChange;
    }

    private void OnDisable()
    {
        _player.OnHealthChanged -= OnHealthChange;
    }

    private void OnHealthChange(int health)
    {
        _healthDisplay.text = health.ToString();
    }
}
