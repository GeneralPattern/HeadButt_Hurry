using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;
    
    public IntData highScore;
    public IntData Health;
    public bool canRun;
    public IntData counterNum;
    public IntData counterUpNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;

    public int minHealth =5;
    public int maxHealth =10;

    public bool CanRun
    {
        get => canRun;
        set => canRun = value;
    }

    private void Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        startEvent.Invoke();
    }

    public void StartCounting()
    {
        StartCoroutine(Counting());

    
    }

    private IEnumerator Counting()
    {

        startCountEvent.Invoke();
        yield return wffuObj;

        while (counterNum.value > 0)
        {
            
            repeatCountEvent.Invoke();
            counterNum.value --;
            yield return wfsObj;
            

        }
        StartCoroutine(CountingUp());
        endCountEvent.Invoke();
        
    }


    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }

    private IEnumerator RepeatUntilFalse()
    {
        while(canRun)
        {
            yield return wfsObj;
            repeatUntilFalseEvent.Invoke();

        }
    }
    public IEnumerator CountingUp()
    {

        yield return wffuObj;

        while (canRun == true)
        {

            repeatCountEvent.Invoke();
            counterNum.value ++;
            yield return wfsObj;

        }

        if(counterNum.value > highScore.value)
        {
            highScore.value = (counterNum.value);
        }
        
        

    }
    public void RandomizeHealth()
    {
         Health.value = Random.Range(5, 10);
    }
}
