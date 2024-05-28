using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public enum SceneType //��˹����͵����� SceneType
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
        Menu7, // �������� 'Num' ���ա˹�觻������ҡ
    }


    // ��С�� Dictionary ����������§ SceneType �Ѻ GameObject
    private Dictionary<SceneType, GameObject> scenes;

    // ��С�� GameObject ����Ѻ���Щҡ
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
        // ��˹��������������Ѻ Dictionary
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

        // ��Ǩ�ͺ��лԴ�����ҹ�ء�ҡ��������
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
        // ǹ�ٻ�����Դ���ͻԴ�ҡ��� SceneType
        foreach (var scene in scenes)
        {
            scene.Value.SetActive(scene.Key == sceneType);
        }
    }

    public void ActivateMultipleScenes(params SceneType[] scenesToActivate)
    {
        // ���ҧ HashSet ���͡����Ҷ֧����Ǵ���Ǣͧ scenesToActivate
        var activeScenes = new HashSet<SceneType>(scenesToActivate);        //HashSet ��˹�ҷ�訴��ª��ͧ͢ SceneType

        // ǹ�ٻ��ҹ�ء�ҡ� dictionary
        foreach (var scene in scenes)
        {
            // ��駤�ҡ����ҹ�������Ѻ��ҩҡ�������� activeScenes �������
            scene.Value.SetActive(activeScenes.Contains(scene.Key));        //Contains ��͡�âմ�����ª���� HashSet ������ç�Ѻ scene.Key
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
