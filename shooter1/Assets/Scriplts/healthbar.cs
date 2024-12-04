
using UnityEngine;
using UnityEngine.Events;

public class healthbar : MonoBehaviour
{
    [SerializeField]
    private float _currentHealth;
    [SerializeField]
    private float _maximumHealth;

    public float RemainingHealthPercentage
    {
      get
      {
        return _currentHealth / _maximumHealth;
      }  
    }

    public UnityEvent OnDied;

    public UnityEvent OnHealthChanged;


public void TakeDamage(float damageAmount)
{
    Debug.Log("damage");
    
    if (_currentHealth == 0)
    {
        return;
    }

    _currentHealth -= damageAmount;
    Debug.Log(_currentHealth);

    OnHealthChanged.Invoke();

    if (_currentHealth <= 0)
    {
        _currentHealth = 0;
         OnDied.Invoke();
    }

  
}
public void AddHealth(float amountToAdd)
    {
        if (_currentHealth == _maximumHealth)
        {
            return;
        }
        _currentHealth += amountToAdd;

        OnHealthChanged.Invoke();
        if (_currentHealth > _maximumHealth)
        {
            _currentHealth = _maximumHealth;
        }
    }
}