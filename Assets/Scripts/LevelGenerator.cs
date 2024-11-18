using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject levelPrefab;
    [SerializeField] private GameObject columnPrefab;
    [SerializeField] private GameObject floorPrefab;
    [SerializeField] private GameObject segmentPrefab;

    [SerializeField] private int floorsNumber;
    [SerializeField] private int floorsGap;
    [SerializeField] private int segmentsNumber;
    [SerializeField] private int segmentsAngle;

    private void Start()
    {
        var levelInstance = Instantiate(levelPrefab);
        var columnInstance = Instantiate(columnPrefab, levelInstance.transform);

        columnInstance.transform.position = new Vector3(0f, floorsNumber * floorsGap * (-1f), 0f);
        columnInstance.transform.localScale = new Vector3(1f, floorsNumber * floorsGap, 1f);


        /*
         * СОЗДАЕМ УРОВЕНЬ (КОЛОНА + ЭТАЖ) *
 
        1. Создать уровень                                                                    ==  (YES)
        2. Создать колону (высота и позиция зависят от floorsNumber и floorsGap)              ==  (YES)
        3. Создать этаж                                                                       ==  (NOO)
        4. Сделать чтобы этажи спавнились на расстоянии между друг другом (floorsGap) по Y    ==  (NOO)
        5. Создать сегменты с отступом в segmentsAngle
        6. Повторить пока не создадим нужное количество segmentsNumber
        7. Повторить пока не создадим нужно количество floorsNumber

        */
    }
}
