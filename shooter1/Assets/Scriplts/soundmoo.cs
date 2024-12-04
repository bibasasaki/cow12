using TMPro.Examples;
using UnityEditor;
using UnityEngine;

public class soundmoo : MonoBehaviour


{

        public float timerLimit;
//при скольки таймер сработает
public float timerFloat;
//сам таймер, он считать будет

//штуки со звуком, я ничего про них не помню
public AudioSource cowAS;
public AudioClip mooAC;

void Update () 
{
    timerFloat += Time.deltaTime;
//таймер увеличивается. Следующая строка проверяет, чтобы он вырос до нужного числа, перезапускает таймер и запускает какое-то действие
if(timerFloat > timerLimit)
{
timerFloat = 0.0f;
Moo();
}

void Moo() 
{
PLaySoundOneShot(mooAC);
СinemachineControl.Instance.ShakeCamera(5f, 2f);

}
}
void PLaySoundOneShot(AudioClip ac)
{
if (cowAS != null)
{
cowAS.PlayOneShot(ac);
}
}
}
