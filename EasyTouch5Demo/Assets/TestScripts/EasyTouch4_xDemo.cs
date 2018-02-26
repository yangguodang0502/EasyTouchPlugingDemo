using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HedgehogTeam.EasyTouch;//HeadhogTeam 是工作室的名字
public class EasyTouch4_xDemo : MonoBehaviour {
void OnEnable()
    {
        EasyTouch.On_TouchStart += OnTouchStart;
        EasyTouch.On_TouchUp += OnTouchEnd;
        EasyTouch.On_Swipe += OnSwipe;
    }
    //事件有订阅就一定有取消订阅在你不需要用到它的的时候
    void OnDisable()
    {
        EasyTouch.On_TouchStart -= OnTouchStart;
        EasyTouch.On_TouchUp -= OnTouchEnd;
        EasyTouch.On_Swipe -= OnSwipe;
    }
    void OnDestory()
    {
        EasyTouch.On_TouchStart -= OnTouchStart;
        EasyTouch.On_TouchUp -= OnTouchEnd;
        EasyTouch.On_Swipe -= OnSwipe;
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
