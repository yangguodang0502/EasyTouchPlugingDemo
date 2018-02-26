using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HedgehogTeam.EasyTouch;
public class EasyTouch5_xDemo : MonoBehaviour {
    void Update()
    {
        Gesture currentGesture = EasyTouch.current;
        if(currentGesture!=null)
        {
            if(EasyTouch.EvtType.On_TouchStart==currentGesture.type)
            {
                OnTouchStart(currentGesture);
            }
            if(EasyTouch.EvtType.On_TouchUp==currentGesture.type)
            {
                OnTouchEnd(currentGesture);
            }
            if(EasyTouch.EvtType.On_Swipe==currentGesture.type)
            {
                OnSwipe(currentGesture);
            }
        }
    }
    void OnTouchStart(Gesture gesture)
    {
        Debug.Log("OnTouchStart");
        Debug.Log("StartPosition::" + gesture.startPosition);
    }
    void OnTouchEnd(Gesture gesture)
    {
        Debug.Log("OnTouchEnd");
        Debug.Log("ActionTime::" + gesture.actionTime);
    }
    void OnSwipe(Gesture gesture)
    {
        Debug.Log("OnSwipe");
        Debug.Log("type::" + gesture.swipe);//操作类型
    }
}
