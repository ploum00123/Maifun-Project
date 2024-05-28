using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public enum SceneType //กำหนดชื่อตัวแปรใน SceneType
    {
        Start,
        MenuList,
        MenuList2,
        Sushi,
        Bento,
        Menu3,
        Menu4,
        Menu5,
        Menu6,
        Menu7, // สมมติว่า 'Num' เป็นอีกหนึ่งประเภทฉาก
    }


    // ประกาศ Dictionary เพื่อเชื่อมโยง SceneType กับ GameObject
    private Dictionary<SceneType, GameObject> scenes;

    // ประกาศ GameObject สำหรับแต่ละฉาก
    public GameObject sceneStart;
    public GameObject sceneMenuList;
    public GameObject sceneMenuList2;
    public GameObject sceneSushi;
    public GameObject sceneBento;
    public GameObject sceneMenu3;
    public GameObject sceneMenu4;
    public GameObject sceneMenu5;
    public GameObject sceneMenu6;
    public GameObject sceneMenu7;



    void Start()
    {
        InitializeScenes();
        ActivateScene(SceneType.Start);
    }



    void InitializeScenes()
    {
        // กำหนดค่าเริ่มต้นให้กับ Dictionary
        scenes = new Dictionary<SceneType, GameObject>
        {
            { SceneType.Start, sceneStart },
            { SceneType.MenuList, sceneMenuList },
            { SceneType.MenuList2, sceneMenuList2 },
            { SceneType.Sushi, sceneSushi },
            { SceneType.Bento, sceneBento },
            { SceneType.Menu3, sceneMenu3 },
            { SceneType.Menu4, sceneMenu4 },
            { SceneType.Menu5, sceneMenu5 },
            { SceneType.Menu6, sceneMenu6 },
            { SceneType.Menu7, sceneMenu7 }
        };

        // ตรวจสอบและปิดการใช้งานทุกฉากในเริ่มต้น
        foreach (var scene in scenes.Values)
        {
            if (scene == null)
            {
                Debug.LogError("One of the scenes has not been assigned in the Inspector.");
            }
            else
            {
                scene.SetActive(false);
            }
        }
    }

    public void ActivateScene(SceneType sceneType)
    {
        // วนลูปเพื่อเปิดหรือปิดฉากตาม SceneType
        foreach (var scene in scenes)
        {
            scene.Value.SetActive(scene.Key == sceneType);
        }
    }

    public void ActivateMultipleScenes(params SceneType[] scenesToActivate)
    {
        // สร้าง HashSet เพื่อการเข้าถึงที่รวดเร็วของ scenesToActivate
        var activeScenes = new HashSet<SceneType>(scenesToActivate);        //HashSet ทำหน้าที่จดรายชื่อของ SceneType

        // วนลูปผ่านทุกฉากใน dictionary
        foreach (var scene in scenes)
        {
            // ตั้งค่าการใช้งานขึ้นอยู่กับว่าฉากนั้นอยู่ใน activeScenes หรือไม่
            scene.Value.SetActive(activeScenes.Contains(scene.Key));        //Contains คือการขีดฆ่ารายชื่อใน HashSet ที่ไม่ตรงกับ scene.Key
        }
    }

    public void ActivateSceneMenuList()
    {
        ActivateScene(SceneType.MenuList);
    }

    public void ActivateSceneMenuList2()
    {
        ActivateScene(SceneType.MenuList2);
    }
    public void ActivateSceneSushi()
    {
        ActivateScene(SceneType.Sushi);
    }

    public void ActivateSceneBento()
    {
        ActivateScene(SceneType.Bento);
    }

    public void ActivateSceneMenu3()
    {
        ActivateScene(SceneType.Menu3);
    }

    public void ActivateSceneMenu4()
    {
        ActivateScene(SceneType.Menu4);
    }

    public void ActivateSceneMenu5()
    {
        ActivateScene(SceneType.Menu5);
    }

    public void ActivateSceneMenu6()
    {
        ActivateScene(SceneType.Menu6);
    }

    public void ActivateSceneMenu7()
    {
        ActivateScene(SceneType.Menu7);
    }
}
