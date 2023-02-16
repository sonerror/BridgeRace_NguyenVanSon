using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ManagerJoytick : MonoBehaviour , IDragHandler , IPointerDownHandler , IPointerUpHandler
{
    private Image imgJoytickBG;
    private Image imgJoytick;
    private Vector2 posInput;


    // Start is called before the first frame update
    void Start()
    {
        imgJoytickBG= GetComponent<Image>();
        imgJoytick= transform.GetChild(0).GetComponent<Image>();

    }
        
    // Update is called once per frame
    public void OnDrag(PointerEventData eventData)
    {
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(
           imgJoytickBG.rectTransform, 
           eventData.position,
           eventData.pressEventCamera,
           out posInput
           ))
        {
            Debug.Log("test");
            posInput.x = posInput.x / (imgJoytickBG.rectTransform.sizeDelta.x);
            posInput.y = posInput.y / (imgJoytickBG.rectTransform.sizeDelta.y);
            Debug.Log(posInput.x.ToString() + "/" + posInput.y.ToString());
            //normalize
            if(posInput.magnitude> 1.0f)
            {
                posInput = posInput.normalized;
            }
            //imgJoytick move
            imgJoytick.rectTransform.anchoredPosition = new Vector2(
                posInput.x * (imgJoytickBG.rectTransform.sizeDelta.x / 2), 
                posInput.y * (imgJoytickBG.rectTransform.sizeDelta.y / 2));
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    } 
    public void OnPointerUp(PointerEventData eventData) 
    {
        posInput = Vector2.zero;
        imgJoytick.rectTransform.anchoredPosition = Vector2.zero;
    }
    public float inputHorizontal()
    {
        if (posInput.x != 0)
        {
            return posInput.x;
        }
        else
            return Input.GetAxis("Horizontal");
    }
    public float inputVertiacl()
    {
        if (posInput.y != 0)
        {
            return posInput.y;
        }
        else
            return Input.GetAxis("Vertical");
    }
}
