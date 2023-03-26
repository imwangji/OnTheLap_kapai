using System;
using UnityEngine;

public enum GamePhase
{
    DrawPhase,
    PlayPhase,
    DiscardPhase,
    EndPhase,
}
public class GameManager: MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private PlayerCharacter _player;
    private TowerFloor _currentFloor;
    private int _currentFloorNumber;
    // 定义楼层更改事件
    public event Action<TowerFloor> OnFloorChanged;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        _player = new PlayerCharacter();
        _currentFloorNumber = 1;
        _currentFloor = new TowerFloor(_currentFloorNumber);
        // 触发楼层更改事件
        OnFloorChanged?.Invoke(_currentFloor);
    }
    void Update()
    {
        // 根据游戏状态和玩家输入执行相应的操作
    }
    public void GoToNextFloor()
    {
        _currentFloorNumber++;
        _currentFloor = new TowerFloor(_currentFloorNumber);
        // 在进入新楼层时，可以更新角色的血量、蓝量等属性
    }
    private void UpdateBuffs(Character target)
    {
        for (int i = 0; i < target.Buffs.Count; i++)
        {
            Buff.Buff buff = target.Buffs[i];
            buff.Apply(target);
            buff.Duration--;

            if (buff.Duration <= 0)
            {
                buff.Remove(target);
                target.Buffs.RemoveAt(i);
                i--; // 防止跳过下一个Buff
            }
        }
    }

    public void EndTurn()
    {
        // 执行回合结束时的逻辑，例如更新Buff效果、检查角色和怪物的状态等
        UpdateBuffs(_player);
        foreach (Monster monster in _currentFloor.Monsters)
        {
            UpdateBuffs(monster);
        }
    }
}
