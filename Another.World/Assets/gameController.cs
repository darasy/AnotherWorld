using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{

    public GameObject Menu;
    public GameObject Inventory;
    public bool CameraDisable = false;
    public bool MouseVisiable = false;
    public bool MenuState = false;
    public bool CheckInventory = false;

    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            CameraDisable = !CameraDisable;
        }
        if (!MouseVisiable)
        {
            Cursor.visible = false;
        }
        else
        {
            Cursor.visible = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (CheckInventory)
            {
                CheckInventory = !CheckInventory;
                Inventory.SetActive(CheckInventory);
            }
            else
            {
                MenuState = !MenuState;
                Menu.SetActive(MenuState);
            }
            CameraDisable = !CameraDisable;
            MouseVisiable = !MouseVisiable;


        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (MenuState)
            { }
            else
            {
                CheckInventory = !CheckInventory;
                Inventory.SetActive(CheckInventory);
                CameraDisable = !CameraDisable;
                MouseVisiable = !MouseVisiable;
            }
        }
    }

}
