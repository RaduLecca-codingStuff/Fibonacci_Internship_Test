using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FibonacciText : MonoBehaviour
{
    // Start is called before the first frame update
    long a;
    long b;
    bool isCoroutineHappening;

    Text text;
    public AudioVisualButtons next;
    public AudioVisualButtons previous;

    public RawImage bkg;
    public Text message;

    AudioSource audi;
    void Awake()
    {
        a = 1;
        b = 0;
     
        text = GetComponent<Text>();
        text.text = b.ToString();
        bkg.enabled = false;
        message.enabled = false;

        audi = GetComponent<AudioSource>();
    }
  
    //backwards movement enumerators
    IEnumerator backwards()
    {
        isCoroutineHappening = true;
        bool gotout=false;
        
            if (text.rectTransform.anchoredPosition.x < 90 && !gotout)
            {
            audi.Play();
                text.rectTransform.anchoredPosition = new Vector2(text.rectTransform.anchoredPosition.x + 15, text.rectTransform.anchoredPosition.y);
                yield return new WaitForSeconds(0.2f);
                StartCoroutine(backwards());
            }
            else if(!gotout)
            {
            audi.Play();
            gotout = true;
                calculations(false);
                text.rectTransform.anchoredPosition = new Vector2(-90, text.rectTransform.anchoredPosition.y);
                
                StartCoroutine(backB());
            }
        next.SetBool(false);
        previous.SetBool(false);
    }
    IEnumerator backB()
    {
        if (text.rectTransform.anchoredPosition.x < 0 )
        {
            audi.Play();
            text.rectTransform.anchoredPosition = new Vector2(text.rectTransform.anchoredPosition.x + 15, text.rectTransform.anchoredPosition.y);
            yield return new WaitForSeconds(0.2f);
            StartCoroutine(backB());
        }
        else
        {
            audi.Play();
            isCoroutineHappening = false;
            next.SetBool(true);
            previous.SetBool(true);
            StopAllCoroutines();
        }

    }
    //forwards movement enumerators
    IEnumerator forwards()
    {
        isCoroutineHappening = true;
        bool gotout = false;
        
        if (text.rectTransform.anchoredPosition.x > -90 && !gotout)
        {
            audi.Play();
            text.rectTransform.anchoredPosition = new Vector2(text.rectTransform.anchoredPosition.x - 15, text.rectTransform.anchoredPosition.y);
            yield return new WaitForSeconds(0.2f);
            StartCoroutine(forwards());
        }
        else if (!gotout)
        {
            audi.Play();
            gotout = true;
            calculations(true);
            text.rectTransform.anchoredPosition = new Vector2(90, text.rectTransform.anchoredPosition.y);

            StartCoroutine(forwB());
        }
        next.SetBool(false);
        previous.SetBool(false);
    }
    IEnumerator forwB()
    {
        if (text.rectTransform.anchoredPosition.x > 0)
        {
            audi.Play();
            text.rectTransform.anchoredPosition = new Vector2(text.rectTransform.anchoredPosition.x - 15, text.rectTransform.anchoredPosition.y);
            yield return new WaitForSeconds(0.2f);
            StartCoroutine(forwB());
        }
        else
        {
            audi.Play();
            isCoroutineHappening = false;
            next.SetBool(true);
            previous.SetBool(true);
            StopAllCoroutines();
        }

    }

    IEnumerator showMessage()
    {
        isCoroutineHappening = true;
        yield return new WaitForSeconds(0.2f);
        bkg.enabled = true;
        yield return new WaitForSeconds(0.2f);
        message.enabled = true;
        yield return new WaitForSeconds(4f);
        StartCoroutine(hideMessage());

    }
    IEnumerator hideMessage()
    {
        a = 1;
        b = 0;
        text.text = b.ToString();
        message.enabled = false;
        yield return new WaitForSeconds(0.2f);
        bkg.enabled = false;
        isCoroutineHappening = false;

    }
    
    //used to go to the next number
    public void TransitionPlus()
    {

        if (b<= 2147483647 && !isCoroutineHappening)
        {
            
            StartCoroutine(forwards());
        }
       else if(b>= 2147483647)
        {
            StartCoroutine(showMessage());

        }
    }
    public void TransitionMinus()
    {
       
        if (b > 0 && !isCoroutineHappening)
        {
            StartCoroutine(backwards());
        }
        
    }

    void calculations(bool dir)
    {
        long d;
        if (dir)
        {
            d = a;
            a = b;
            b += d;
        }
        else
        {
            d = b;
            b = a;
            a = d - a;
        }

        text.text = b.ToString();
    }
}
