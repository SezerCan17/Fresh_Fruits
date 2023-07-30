using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.UI.ScrollRect;

public class Camera_ : MonoBehaviour
{
    public Transform right_transform;
    public Transform left_transform;
    public Transform center_transform;
    private Transform from;
    private Transform to;
    private Transform currentTransform;
    private Transform targetTransform;
    public bool rlook = false;
    public bool llook = false;
    public bool sagda = false;
    public bool solda = false;
    public bool ortada = true;
    

    private float timeCount = 5.0f;
    public Transform target;
 
    



    public void Update()
    {
        if (rlook)
        {
            if (ortada)
            {
                Debug.Log("1 e girdi");
                from = center_transform;
                to = right_transform;
                transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, timeCount );
                timeCount = timeCount + Time.deltaTime;

                rlook_();

            }
            else if (solda)
            {
                Debug.Log("2 ye girdi");
                from = left_transform;
                to = center_transform;
                transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, timeCount);
                timeCount = timeCount + Time.deltaTime;
                centerlook();
            }


        }
        else if (llook)
        {
            if (sagda)
            {
                Debug.Log("3 e girdi");
                from = right_transform;
                to = center_transform;
                transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, timeCount);
                timeCount = timeCount + Time.deltaTime;
                Debug.Log("centerlookta");
                centerlook();
            }
            else if (ortada)
            {
                Debug.Log("4 e girdi");
                from = center_transform;
                to = left_transform;
                transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, timeCount);
                timeCount = timeCount + Time.deltaTime;
                llook_();

            }

        }

    }


    public void RightLook()
    {
        rlook = true;
        Update();
    }

    public void LeftLook()
    {
        llook = true;
        Update();
    }

    public void rlook_()
    {
        Debug.Log("rlokk ta");
        rlook = false;
        llook = false;
        ortada = false;
        sagda = true;
        solda = false;
    }
    public void llook_()
    {
        Debug.Log("llook ta");
        llook = false;
        rlook = false;
        ortada = false;
        solda = true;
        sagda = false;
    }
    public void centerlook()
    {
        Debug.Log("centerlookta");
        ortada = true;
        rlook = false;
        llook = false;
        sagda = false;
        solda = false;
    }

}








