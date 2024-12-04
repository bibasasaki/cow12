using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthbarUI : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Image _healthBarForegroundImage;
   public void UpdateHealthBar(healthbar healthbar)
   {
    _healthBarForegroundImage.fillAmount = healthbar.RemainingHealthPercentage;

   }
}
