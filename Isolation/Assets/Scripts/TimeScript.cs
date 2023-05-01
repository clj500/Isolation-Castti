using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeScript : MonoBehaviour
{
    private float timerDuration = 1f * 60f;
    private float timer;

    [SerializeField] private bool countDown = true;

    [SerializeField] private TextMeshProUGUI firstMinute;
    [SerializeField] private TextMeshProUGUI secondMinute;
    [SerializeField] private TextMeshProUGUI seperator;
    [SerializeField] private TextMeshProUGUI firstSecond;
    [SerializeField] private TextMeshProUGUI secondSecond;

    private float flashTimer;
    private float flashDuration = 5f;

    public GameObject nighttime;
    public bool night = false;

    void Start()
    {
        ResetTimer();
    }

    void Update()
    {
        if (countDown && timer > 0)
        {
            timer -= Time.deltaTime;
            UpdateTimerDisplay(timer);
        }

        else if (countDown && timer == 0)
        {
            Flash();
            UpdateDay();
            ResetTimer();
        }

        else if (!countDown && timer > timerDuration - 5f)
        {
            Flash();
            UpdateDay();
        }

        else if (!countDown && timer < timerDuration)
        {
            timer += Time.deltaTime;
            UpdateTimerDisplay(timer);
        }

        else
        {
        }
    }

    private void ResetTimer()
    {
        if (countDown)
        {
            timer = timerDuration;
        }

        else
        {
            timer = 0;
        }

        UpdateTimerDisplay(timer);
        SetTextDisplay(true);
    }

    private void UpdateTimerDisplay(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        string currentTime = string.Format("{0:00}{1:00}", minutes, seconds);

        firstMinute.text = currentTime[0].ToString();
        secondMinute.text = currentTime[1].ToString();
        firstSecond.text = currentTime[2].ToString();
        secondSecond.text = currentTime[3].ToString();
    }

    private void Flash()
    {
        if (countDown && timer != 0)
        {
            timer = 0;
            UpdateTimerDisplay(timer);
        }

        else if (!countDown && timer != timerDuration)
        {
            timer = 0;
            UpdateTimerDisplay(timer);
        }

        if (flashTimer <= 0)
        {
            flashTimer = flashDuration;
        }

        else if (flashTimer >= flashDuration / 2)
        {
            flashTimer -= Time.deltaTime;
            SetTextDisplay(false);
        }

        else
        {
            flashTimer -= Time.deltaTime;
            SetTextDisplay(true);
        }
    }

    private void UpdateDay()
    {        
        if(night == false)
        {
            nighttime.SetActive(true);
        }

        if (night == true)
        {
            nighttime.SetActive(false);
        }
    }

    private void SetTextDisplay(bool enabled)
    {
        firstMinute.enabled = enabled;
        secondMinute.enabled = enabled;
        seperator.enabled = enabled;
        firstSecond.enabled = enabled;
        secondSecond.enabled = enabled;
    }
}
