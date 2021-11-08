using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Geometry : MonoBehaviour
{
    public Dropdown dropDown_Option;

    public GameObject square;
    public GameObject rectangle;
    public GameObject triangle;
    public GameObject circle;

    public GameObject area_Square;
    public GameObject per_Square;

    public GameObject area_rectangle;
    public GameObject per_rectangle;

    public GameObject area_triangle;
    public GameObject per_triangle;

    public GameObject area_circle;
    public GameObject per_circle;
    private void Start()
    {
        square.SetActive(true);
        area_Square.SetActive(true);
        per_Square.SetActive(true);

        rectangle.SetActive(false);
        area_rectangle.SetActive(false);
        per_rectangle.SetActive(false);

        triangle.SetActive(false);
        area_triangle.SetActive(false);
        per_triangle.SetActive(false);

        circle.SetActive(false);
        area_circle.SetActive(false);
        per_circle.SetActive(false);
    }

    public void Option()
    {
        switch(dropDown_Option.options[dropDown_Option.value].text)
        {
            case "Square":
                square.SetActive(true);
                area_Square.SetActive(true);
                per_Square.SetActive(true);

                rectangle.SetActive(false);
                area_rectangle.SetActive(false);
                per_rectangle.SetActive(false);

                triangle.SetActive(false);
                area_triangle.SetActive(false);
                per_triangle.SetActive(false);

                circle.SetActive(false);
                area_circle.SetActive(false);
                per_circle.SetActive(false);
                break;
            case "Rectangle":
                
                rectangle.SetActive(true);
                area_rectangle.SetActive(true);
                per_rectangle.SetActive(true);

                square.SetActive(false);
                area_Square.SetActive(false);
                per_Square.SetActive(false);

                triangle.SetActive(false);
                area_triangle.SetActive(false);
                per_triangle.SetActive(false);

                circle.SetActive(false);
                area_circle.SetActive(false);
                per_circle.SetActive(false);
                break;
            case "Triangle":
                triangle.SetActive(true);
                area_triangle.SetActive(true);
                per_triangle.SetActive(true);

                square.SetActive(false);
                area_Square.SetActive(false);
                per_Square.SetActive(false);

                rectangle.SetActive(false);
                area_rectangle.SetActive(false);
                per_rectangle.SetActive(false);

                circle.SetActive(false);
                area_circle.SetActive(false);
                per_circle.SetActive(false);
                break;
            case "Circle":
                circle.SetActive(true);
                area_circle.SetActive(true);
                per_circle.SetActive(true);

                square.SetActive(false);
                area_Square.SetActive(false);
                per_Square.SetActive(false);

                rectangle.SetActive(false);
                area_rectangle.SetActive(false);
                per_rectangle.SetActive(false);

                triangle.SetActive(false);
                area_triangle.SetActive(false);
                per_triangle.SetActive(false);
                break;
        }
    }    
}
