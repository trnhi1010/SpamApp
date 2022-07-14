/*
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IAP_Item_Base : MonoBehaviour
{
    [SerializeField]
    internal int _productID;

    private List<string> id = new List<string>() {
        "mymeow_meo_1.1",
        "mymeow_meo_1.2",
        "mymeow_meo_1.3",
        "mymeow_meo_1.4",
        "mymeow_meo_1.5",
        "mymeow_meo_1.6",
        "mymeow_eow_2.1",
        "mymeow_eow_2.2",
        "mymeow_eow_2.3",
        "mymeow_eow_2.4",
        "mymeow_eow_2.5",
        "mymeow_eow_2.6"
    };


    private void OnEnable()
    {
        GetComponentInChildren<UnityEngine.UI.Button>().onClick.AddListener(Buy);
        _productID = transform.GetSiblingIndex();
    }

    [SerializeField]
    IAP_Manager _iapManager;
    //SubcribeManager subManager;

    private void Awake()
    {
        _iapManager = FindObjectOfType<IAP_Manager>();
    }

    private void Buy()
    {
        Debug.Log(id[_productID]);
        if (_iapManager != null && !string.IsNullOrEmpty(id[_productID]))
        {
            _iapManager.BuyProductID(id[_productID], (result) =>
            {
                BuyCallBack(result, id[_productID]);
            });
        }
    }

    private void OnDisable()
    {
        GetComponentInChildren<UnityEngine.UI.Button>().onClick.RemoveAllListeners();
    }

    public virtual void BuyCallBack(bool result, string productID)
    {
        //if (subManager == null)
        //{
        //    subManager = FindObjectOfType<SubcribeManager>();
        //}

        if (productID.Equals(id[0]))
        {
            //DataManager.instance.SetHeart(25);
        }

        if (productID.Equals(id[1]))
        {
        }

        if (productID.Equals(id[2]))
        {
        }

        if (productID.Equals(id[3]))
        {
        }

        if (productID.Equals(id[4]))
        {
        }
        if (productID.Equals(id[5]))
        {
        }

        //sub
        //if (subManager == null) return;

        //if (productID.Equals(id[6]))
        //{
        //    subManager.UnlockSub(1);
        //}

        //if (productID.Equals(id[7]))
        //{
        //    subManager.UnlockSub(2);
        //}

        //if (productID.Equals(id[8]))
        //{
        //    subManager.UnlockSub(3);
        //}

        //if (productID.Equals(id[9]))
        //{
        //    subManager.UnlockSub(4);
        //}

        //if (productID.Equals(id[_productID]))
        //{
        //    subManager.UnlockSub(10);
        //}

        //if (productID.Equals(id[_productID]))
        //{
        //    subManager.UnlockSub(11);
        //}
        //subManager.AddCoinEveryDay();
    }

}
*/
