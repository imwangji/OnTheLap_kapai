using System.Collections.Generic;

namespace KapaiGame
{
    public class CardManager
    {
        // 单例
        private static readonly CardManager _instance = new CardManager();
        public static CardManager Instance { get { return _instance; } }

        // 用于存储卡片的列表
        private List<Card> registeredCards;

        // 静态构造函数
        static CardManager()
        {
        }
        // 私有构造函数，防止外部实例化
        private CardManager()
        {
            // 初始化注册卡片列表
            registeredCards = new List<Card>
            {
                new FireballCard(),
            };
        }

        public List<Card> DrawCard()
        {
            List<Card> selectedCards = new List<Card>();
            int numCardsToDraw = UnityEngine.Random.Range(2, 4); // 随机抽取2到3张卡片

            for (int i = 0; i < numCardsToDraw; i++)
            {
                int randomIndex = UnityEngine.Random.Range(0, registeredCards.Count); // 从注册卡片列表中随机选择一个索引
                Card selectedCard = registeredCards[randomIndex]; // 选择随机索引对应的卡片
                selectedCards.Add(selectedCard); // 将选中的卡片添加到选中卡片列表中
            }

            return selectedCards;
        }
    }
}