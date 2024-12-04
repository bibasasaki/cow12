using Cinemachine;
using UnityEngine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class СinemachineControl : MonoBehaviour
{
    public static СinemachineControl Instance {get; private set;}
    
    private CinemachineVirtualCamera cinemachine;
    private CinemachineBasicMultiChannelPerlin perlin;
   
    private float shakeTimer, shakeTimerTotal, startingIntensity;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
        cinemachine = GetComponent<CinemachineVirtualCamera>();
        perlin = cinemachine.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
    }
    private void Update()
    {
       
        if(shakeTimer > 0){
            shakeTimer -= Time.deltaTime;
            perlin.m_AmplitudeGain = Mathf.Lerp(startingIntensity, 0f, 1 - (shakeTimer / shakeTimerTotal));
            
        }
    }
   
    public void ShakeCamera(float intensity, float time){
        perlin.m_AmplitudeGain = intensity;
        startingIntensity = intensity;
        shakeTimerTotal = time;
        shakeTimer = time;
    }
}
