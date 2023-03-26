using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerFloor
{
    public List<Monster> Monsters = new List<Monster>();
    public int FloorNumber;

    public TowerFloor(int floorNumber)
    {
        FloorNumber= floorNumber;
        Monsters = GenerateRandomMonsters();
    }

    private List<Monster> GenerateRandomMonsters()
    {
        var monster = new List<Monster>();
        int numMonsters = UnityEngine.Random.Range(1, 4);

        for (int i = 0; i < numMonsters;)
        {
            // 从MonsterManager获取所有可用的怪物
            List<Monster> availableMonsters = MonsterManager.Instance.GetAvailableMonstersByFloor(FloorNumber);

            // 随机选择一个怪物
            int randomIndex = UnityEngine.Random.Range(0, availableMonsters.Count);
            Monster selectedMonster = availableMonsters[randomIndex];

            // 检查选中的怪物是否已经存在于monsters列表中
            if (!monster.Contains(selectedMonster))
            {
                // 如果不存在，则将其添加到monsters列表中，并增加计数器
                monster.Add(selectedMonster);
                i++;
            }
        }
        return monster;
    }
}
