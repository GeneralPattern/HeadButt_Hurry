using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;
    
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
        //StartCoroutine(CountUp());
    
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

        endCountEvent.Invoke();
        
    }

    /*private IEnumerator CountUp()
    {
        yield return wffuObj;

        while (counterNum.value > 0)
        {

            counterNum.value ++;
            yield return wfsObj;

        }
    }*/

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

        while (counterNum.value < 20)
        {

            counterNum.value ++;
            yield return wfsObj;

        }
        while (counterNum.value < 40)
        {
            minHealth = 10;
            maxHealth = 15;
            counterNum.value ++;
            yield return wfsObj;

        }
        

    }
    public void RandomizeHealth()
    {
         Health.value = Random.Range(5, 10);
    }
}
