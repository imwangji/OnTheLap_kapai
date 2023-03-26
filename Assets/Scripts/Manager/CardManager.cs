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
                // 在这里添加您的卡片实例
                // ...
            };
        }

        // GetCardsByLevel方法，返回一组卡片
        public List<Card> GetAvailableCardsByLevel(int level)
        {
            // 根据等级选择合适的卡片
            List<Card> selectedCards = new List<Card>();

            // 在此处实现您自己的逻辑，根据等级筛选卡片
            // 示例：选择所有已注册的卡片
            foreach (Card card in registeredCards)
            {
                selectedCards.Add(card);
            }

            return selectedCards;
        }
    }
}