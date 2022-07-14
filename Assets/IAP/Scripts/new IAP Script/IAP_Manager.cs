using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class IAP_Manager : MonoBehaviour, IStoreListener
{
    public static IAP_Manager instance;

    private static IStoreController m_StoreController;
    private static IExtensionProvider m_StoreExtensionProvider;

    public List<IAP_Product> _arrProducts = new List<IAP_Product>();

    public string x;
    public string y;
    public string z;
    Action<bool> callBackBuyProduct;
    private void Awake()
    {
        id = new List<string>()  {
        $"{x}_{y}_1.1",
        $"{x}_{y}_1.2",
        $"{x}_{y}_1.3",
        $"{x}_{y}_1.4",
        $"{x}_{y}_1.5",
        $"{x}_{y}_1.6",

        $"{x}_{z}_2.1",
        $"{x}_{z}_2.2",
        $"{x}_{z}_2.3",
        $"{x}_{z}_2.4",
        $"{x}_{z}_2.5",
        $"{x}_{z}_2.6",
    };

        DontDestroyOnLoad(gameObject);

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public static List<string> id = new List<string>();

    void Start()
    {
        if (m_StoreController == null)
        {
            InitializePurchasing();
        }
    }

    public void InitializePurchasing()
    {
        Debug.LogError("InitializePurchasing");

        if (IsInitialized())
        {
            return;
        }

        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        for (int i = 0; i < id.Count; i++)
        {
            if (i < 12)
            {
                IAP_Product item = new IAP_Product()
                {
                    _ProductID = id[i],
                    _Type = ProductType.NonConsumable
                };
                builder.AddProduct(id[i], ProductType.NonConsumable);
                _arrProducts.Add(item);
            }
            else
            {
                IAP_Product item = new IAP_Product()
                {
                    _ProductID = id[i],
                    _Type = ProductType.Subscription
                };
                builder.AddProduct(id[i], ProductType.Subscription);
                _arrProducts.Add(item);
            }
        }
        UnityPurchasing.Initialize(this, builder);
    }

    private bool IsInitialized()
    {

        return m_StoreController != null && m_StoreExtensionProvider != null;
    }

    public void BuyProductID(string productId, Action<bool> callBack = null)
    {
        callBackBuyProduct = null;

        if (IsInitialized())
        {

            Product product = m_StoreController.products.WithID(productId);
            string price = product.metadata.localizedPriceString;
            
            if (product != null && product.availableToPurchase)
            {
                if (callBack != null)
                {
                    callBackBuyProduct = callBack;                    
                }

                Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));
                m_StoreController.InitiatePurchase(product);
            }
            else
            {
                Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");

                if (callBack != null)
                    callBack.Invoke(false);
            }
        }

        else
        {
            Debug.Log("BuyProductID FAIL. Not initialized.");

            if (callBack != null)
                callBack.Invoke(false);
        }
    }

    public string GetLocalizedPrice(string productId)
    {
        if (IsInitialized())
        {
            Product product = m_StoreController.products.WithID(productId);

            if (product != null && product.availableToPurchase)
            {
                return product.metadata.localizedPriceString;
            }
            else
            {
                return "Loading...";
            }
        }

        return "Loading...";
    }

    public string GetLocalizedTitle(string productId)
    {
        if (IsInitialized())
        {
            Product product = m_StoreController.products.WithID(productId);

            if (product != null && product.availableToPurchase)
            {
                return product.metadata.localizedTitle;
            }
            else
            {
                return "Loading...";
            }
        }

        return "Loading...";
    }

    public void RestorePurchases()
    {
        // If Purchasing has not yet been set up ...
        if (!IsInitialized())
        {
            Debug.Log("RestorePurchases FAIL. Not initialized.");
            return;
        }


        if (Application.platform == RuntimePlatform.IPhonePlayer ||
            Application.platform == RuntimePlatform.OSXPlayer)
        {
            Debug.Log("RestorePurchases started ...");
            var apple = m_StoreExtensionProvider.GetExtension<IAppleExtensions>();
            apple.RestoreTransactions((result) =>
            {
                Debug.Log("RestorePurchases continuing: " + result + ". If no further messages, no purchases available to restore.");

                if (result)
                {
                    PlayerPrefs.SetInt("PurchasedInfinityLife", 1);
                    PlayerPrefs.SetInt("PurchasedNoAds", 1);

                }

            });
        }
        else
        {
            Debug.Log("RestorePurchases FAIL. Not supported on this platform. Current = " + Application.platform);
        }
    }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {

        Debug.Log("OnInitialized: PASS");
        m_StoreController = controller;
        m_StoreExtensionProvider = extensions;
    }

    public void OnInitializeFailed(InitializationFailureReason error)
    {

        Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
    }


    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {

        int count = 0;
        foreach (var product in _arrProducts)
        {
            if (String.Equals(args.purchasedProduct.definition.id, product._ProductID, StringComparison.Ordinal))
            {
                Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
                count++;
            }
        }

        if (count == 0)
        {
            Debug.Log(string.Format("ProcessPurchase: FAIL. Unrecognized product: '{0}'", args.purchasedProduct.definition.id));
        }
        else
        {
            if (callBackBuyProduct != null)
                callBackBuyProduct.Invoke(true);
        }

        return PurchaseProcessingResult.Complete;
    }


    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {

        Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));

        if (callBackBuyProduct != null)
            callBackBuyProduct.Invoke(false);
    }
}

[Serializable]
public struct IAP_Product
{
    public string _ProductID;
    public ProductType _Type;
    public string _SubscriptionName;
    public bool isBuy;
}

