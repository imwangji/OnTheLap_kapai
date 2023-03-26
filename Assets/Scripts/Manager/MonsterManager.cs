using System.Collections.Generic;

public class MonsterManager
{
    // 单例
    private static readonly MonsterManager _instance = new MonsterManager();
    public static MonsterManager Instance { get { return _instance; } }

    // 用于存储怪物的列表
    private List<Monster> registeredMonsters;

    // 静态构造函数
    static MonsterManager()
    {
    }
    // 私有构造函数，防止外部实例化
    private MonsterManager()
    {
        // 初始化注册怪物列表
        registeredMonsters = new List<Monster>
        {
           new Goblin(),
           new Ogre(),
           new Troll(),
           new Vampire(),
           new Wraith(),
        };
    }

    // GetMonsterByFloor方法，返回一组怪物
    public List<Monster> GetAvailableMonstersByFloor(int floor)
    {
        // 根据楼层数选择合适的怪物
        List<Monster> selectedMonsters = new List<Monster>();

        // 在此处实现您自己的逻辑，根据楼层数筛选怪物
        // 示例：选择所有已注册的怪物
        foreach (Monster monster in registeredMonsters)
        {
            selectedMonsters.Add(monster);
        }

        return selectedMonsters;
    }
}
