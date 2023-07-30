using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using UnityEngine.UI;
using TMPro;



public class ObjectsMoving : MonoBehaviour
{
    
    Vector3 offset;
    public string destinationTag = "DropArea";
    Vector3 firstPos;
    public Vector3 torbaPos;
    

    public Fruits fruits_;
    public Customer customer_;
    public FruitJuice fruitJuice_;
    public OrderCalculate orderCal;
    public Order order;
    public Rotten_Apple rottenApple;
    private string fruitName;
    public string fruitName2;
    public GameObject tezgah;
    public GameObject targetCollider;
    public AnimatorController animatorController;
    public GameObject Torba;
    public int index;
    
    
    void OnMouseDown()
    {
        fruitName2 = gameObject.name;
        fruitName = gameObject.tag;

        
        Debug.Log("Object Tag: " + fruitName);
        Debug.Log("Object name:123 " + fruitName2);
        rottenApple.Rotten_FruitsControl(fruitName2);
        Debug.Log("rotten789:" + rottenApple.rotten);
        index=rottenApple.index;
        if(rottenApple.rotten)
        {
            rottenApple.Rotten_appleControl();
            orderCal.OrderCalculate2_(gameObject.name);
        }
        else { orderCal.OrderCalculate_(fruitName); }
        
        
        

        firstPos = transform.position;
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        offset = transform.position - MouseWorldPosition();
        transform.GetComponent<Collider>().enabled = false;
        name = gameObject.tag;
        Debug.Log(name);
    }

    void OnMouseDrag()
    {
        transform.position = MouseWorldPosition() + offset;
    }

    void OnMouseUp()
    {
        var rayOrigin = Camera.main.transform.position;
        var rayDirection = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit hitInfo;
        if (Physics.Raycast(rayOrigin, rayDirection, out hitInfo))
        {
            
            if (name!= destinationTag && hitInfo.transform.tag == destinationTag)
            {
                transform.position = hitInfo.transform.position;
                gameObject.GetComponent<MeshRenderer>().enabled = false;
                transform.position = firstPos;

            }
            else if(name == "DropArea" && hitInfo.transform.tag == "customer")
            {
                Debug.Log("Aldý"); 
                customer_.target1_finished = true;
                animatorController.WalkingAnim();
                customer_.agentTarget2 = true;
                order.images[order.Random_Image_Num].gameObject.SetActive(false);
                orderCal.ScoreCalculate();
                transform.position = torbaPos;
                
            }
            
            else if (name == "DropArea" && hitInfo.transform.tag == "tezgah")
            {
                Debug.Log("tezgahta");
                transform.position = tezgah.transform.position;
            }
            else if (name == destinationTag && hitInfo.transform.tag != "customer")
            {
                transform.position = firstPos;
            }
            else if(name!=destinationTag && hitInfo.transform.tag=="fruitJuiceMachine")
            {
                fruitJuice_.FruitJuiceMachine(name);
                transform.position = hitInfo.transform.position;
                gameObject.GetComponent<MeshRenderer>().enabled = false;
                transform.position = firstPos;
            }

            else
            {
                transform.position = firstPos;
                gameObject.GetComponent<MeshRenderer>().enabled = false;
            }

        }
        else
        {
            transform.position = firstPos;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        transform.GetComponent<Collider>().enabled = true;

    }

    public void TorbaPos()
    {
        transform.position = firstPos;
    }



    Vector3 MouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}
