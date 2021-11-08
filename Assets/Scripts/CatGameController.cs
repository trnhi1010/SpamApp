using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CatGameController : MonoBehaviour
{
    public Button btnRibbon, btnBall, btnFood;
    public GameObject txtRibbonSold, txtBallSold, txtFoodSold;
    public Text txtRibbonPrice, txtBallPrice, txtFoodPrice;

    public GameObject hairRibbon, ballOfYarn, food;
    public Text txtLove;
    public int loveAmount;

    private bool isRibbonSold, isBallSold, isFoodSold;
    public int ribbonPrice = 10, ballPrice = 20, foodPrice = 30;

    private void Start()
    {
        hairRibbon.gameObject.SetActive(false);
        ballOfYarn.gameObject.SetActive(false);
        food.gameObject.SetActive(false);

        btnRibbon.interactable = false;
        btnBall.interactable = false;
        btnFood.interactable = false;

        txtRibbonSold.gameObject.SetActive(false);
        txtBallSold.gameObject.SetActive(false);
        txtFoodSold.gameObject.SetActive(false);

        txtRibbonPrice.text = ribbonPrice.ToString() + " Love";
        txtBallPrice.text = ballPrice.ToString() + " Love";
        txtFoodPrice.text = foodPrice.ToString() + " Love";
    }

    private void Update()
    {
        txtLove.text = loveAmount + " Love";
        DoYouHaveEnoughLoveToBuySmth();
    }

    public void IncreaseLoveAmount()
    {
        Debug.Log("Click");
        loveAmount += 1;
    }

    public void SellRibbon()
    {
        hairRibbon.gameObject.SetActive(true);
        loveAmount -= ribbonPrice;
        isRibbonSold = true;
        txtRibbonSold.gameObject.SetActive(true);
        txtRibbonPrice.gameObject.SetActive(false);
    }
    public void SellBall()
    {
        ballOfYarn.gameObject.SetActive(true);
        loveAmount -= ballPrice;
        isBallSold = true;
        txtBallSold.gameObject.SetActive(true);
        txtBallPrice.gameObject.SetActive(false);
    }
    public void SellFood()
    {
        food.gameObject.SetActive(true);
        loveAmount -= foodPrice;
        isFoodSold = true;
        txtFoodSold.gameObject.SetActive(true);
        txtFoodPrice.gameObject.SetActive(false);
    }
    void DoYouHaveEnoughLoveToBuySmth()
    {
        if (loveAmount < ribbonPrice)
            btnRibbon.interactable = false;
        if (loveAmount < ballPrice)
            btnBall.interactable = false;
        if (loveAmount < foodPrice)
            btnFood.interactable = false;

        if (!isRibbonSold && loveAmount >= ribbonPrice)
            btnRibbon.interactable = true;
        if (!isBallSold && loveAmount >= ballPrice)
            btnBall.interactable = true;
        if (!isFoodSold && loveAmount >= foodPrice)
            btnFood.interactable = true;

    }
}
