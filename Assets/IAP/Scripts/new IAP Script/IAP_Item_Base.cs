using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IAP_Item_Base : MonoBehaviour
{
    [SerializeField]
    internal int _productID;

    private void OnEnable()
    {
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(Buy);
        GetTitle();
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
        Debug.Log(IAP_Manager.id[_productID]);
        if (_iapManager != null && !string.IsNullOrEmpty(IAP_Manager.id[_productID]))
        {
            _iapManager.BuyProductID(IAP_Manager.id[_productID], (result) =>
            {
                //BuyCallBack(result, IAP_Manager.id[_productID]);
            });
        }
    }

    private void OnDisable()
    {
        GetComponentInChildren<UnityEngine.UI.Button>().onClick.RemoveAllListeners();
    }

    public virtual void BuyCallBack(bool result, string productID)
    {
        if (!result) return;

        if (productID.Equals(IAP_Manager.id[0]))
        {
            if (IAP_Manager.instance._arrProducts[0].isBuy == false)
            {
            }
        }

        if (productID.Equals(IAP_Manager.id[1]))
        {
            if (IAP_Manager.instance._arrProducts[1].isBuy == false)
            {
            }
        }

        if (productID.Equals(IAP_Manager.id[2]))
        {
            if (IAP_Manager.instance._arrProducts[2].isBuy == false)
            {
            }
        }

        if (productID.Equals(IAP_Manager.id[3]))
        {
            if (IAP_Manager.instance._arrProducts[3].isBuy == false)
            {
            }
        }
        if (productID.Equals(IAP_Manager.id[4]))
        {
            if (IAP_Manager.instance._arrProducts[4].isBuy == false)
            {
            }
        }
        if (productID.Equals(IAP_Manager.id[5]))
        {
            if (IAP_Manager.instance._arrProducts[5].isBuy == false)
            {
            }
        }
        if (productID.Equals(IAP_Manager.id[6]))
        {
            if (IAP_Manager.instance._arrProducts[6].isBuy == false)
            {
            }
        }
    }

    public virtual void GetTitle()
    {
        gameObject.transform.GetComponentInChildren<Text>().text = IAP_Manager.instance.GetLocalizedTitle(IAP_Manager.id[_productID]);
    }
}
