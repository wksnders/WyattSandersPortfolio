using System.Data;

namespace WyattSandersPortfolio.Models.GameModels
{
    public struct ChestProbabilitiesToItem
    {
        public int weight;
        public GameItem item;
    }
    public static class DailyRandomChest
    {
        static List<ChestProbabilitiesToItem> dailyProbToItems = new List<ChestProbabilitiesToItem>{
            new ChestProbabilitiesToItem{ weight = 1, item = new GameItem{
                Name = "Pants",
                GoldValue = 10,
                Quantity = 1,
                ItemSize = 20
            } },
            new ChestProbabilitiesToItem{ weight = 3, item = new GameItem{
                Name = "Dragon Scale Armor",
                GoldValue = 500,
                Quantity = 1,
                ItemSize = 50
            } },
            new ChestProbabilitiesToItem{ weight = 2, item = new GameItem{
                Name = "Potion of Healing",
                GoldValue = 25,
                Quantity = 1,
                ItemSize = 5
            } },
            new ChestProbabilitiesToItem{ weight = 1, item = new GameItem{
                Name = "Mystic Wand",
                GoldValue = 300,
                Quantity = 1,
                ItemSize = 10
            } },
            new ChestProbabilitiesToItem{ weight = 5, item = new GameItem{
                Name = "Herbal Tea",
                GoldValue = 5,
                Quantity = 1,
                ItemSize = 1
            } },
            new ChestProbabilitiesToItem{ weight = 4, item = new GameItem{
                Name = "Dwarven Axe",
                GoldValue = 150,
                Quantity = 1,
                ItemSize = 25
            } },
            new ChestProbabilitiesToItem{ weight = 2, item = new GameItem{
                Name = "Enchanted Cloak",
                GoldValue = 200,
                Quantity = 1,
                ItemSize = 10
            } },
            new ChestProbabilitiesToItem{ weight = 1, item = new GameItem{
                Name = "Phoenix Feather",
                GoldValue = 1000,
                Quantity = 1,
                ItemSize = 2
            } },
            new ChestProbabilitiesToItem{ weight = 3, item = new GameItem{
                Name = "Runestone",
                GoldValue = 50,
                Quantity = 1,
                ItemSize = 3
            } },
            new ChestProbabilitiesToItem{ weight = 1, item = new GameItem{
                Name = "Sorcerer's Stone",
                GoldValue = 750,
                Quantity = 1,
                ItemSize = 5
            } },
            new ChestProbabilitiesToItem{ weight = 2, item = new GameItem{
                Name = "Goblin Dagger",
                GoldValue = 50,
                Quantity = 1,
                ItemSize = 5
            } },
            new ChestProbabilitiesToItem{ weight = 4, item = new GameItem{
                Name = "Silvered sword",
                GoldValue = 220,
                Quantity = 1,
                ItemSize = 5
            } },
            new ChestProbabilitiesToItem{ weight = 3, item = new GameItem{
                Name = "Spellbook",
                GoldValue = 250,
                Quantity = 1,
                ItemSize = 20
            } },
            new ChestProbabilitiesToItem{ weight = 5, item = new GameItem{
                Name = "Iron Ore",
                GoldValue = 15,
                Quantity = 1,
                ItemSize = 50
            } },
            new ChestProbabilitiesToItem{ weight = 1, item = new GameItem{
                Name = "Unicorn Horn",
                GoldValue = 1200,
                Quantity = 1,
                ItemSize = 7
            } },
            new ChestProbabilitiesToItem{ weight = 2, item = new GameItem{
                Name = "Magic Lantern",
                GoldValue = 200,
                Quantity = 1,
                ItemSize = 15
            } },
            new ChestProbabilitiesToItem{ weight = 3, item = new GameItem{
                Name = "Ancient Relic",
                GoldValue = 500,
                Quantity = 1,
                ItemSize = 25
            } },
            new ChestProbabilitiesToItem{ weight = 2, item = new GameItem{
                Name = "Mermaid's Tear",
                GoldValue = 300,
                Quantity = 1,
                ItemSize = 1
            } },
            new ChestProbabilitiesToItem{ weight = 4, item = new GameItem{
                Name = "Healing Herb",
                GoldValue = 10,
                Quantity = 1,
                ItemSize = 2
            } },
            new ChestProbabilitiesToItem{ weight = 3, item = new GameItem{
                Name = "Crystal Shard",
                GoldValue = 60,
                Quantity = 1,
                ItemSize = 5
            } }
            };
        public static RandomItemChest GetDailyChest()
        {
            Random random = new Random(DateTime.Today.DayOfYear);

            return new RandomItemChest(dailyProbToItems, random, 120, 2400);
        }
    }

    public class RandomItemChest
    {

        public List<GameItem> items;
        int contentsTotalSize;
        public int gold;

        /// <summary>
        /// Uses seed to produce a chest full of random items
        /// </summary>
        public RandomItemChest(List<ChestProbabilitiesToItem> probToItems, Random seededRandom, int chestSize, int minChestValue)
        {
            contentsTotalSize = 0;
            gold = 0;
            items = new List<GameItem>();
            FillChest(probToItems, seededRandom, chestSize, minChestValue);
        }

        void FillChest(List<ChestProbabilitiesToItem> probToItems, Random seededRandom, int chestSize, int minChestValue)
        {
            int currentValue = 0;
            int sum = 0;
            foreach (ChestProbabilitiesToItem item in probToItems)
            {
                sum += item.weight;
            }
            while (true)
            {
                int target = seededRandom.Next(sum);
                foreach (ChestProbabilitiesToItem probabilityItem in probToItems)
                {
                    target -= probabilityItem.weight;
                    if (target <= 0)
                    {
                        if (TryAddItem(probabilityItem.item, chestSize))
                        {
                            currentValue += probabilityItem.item.GoldValue;
                            break;
                        }
                        else
                        {
                            //Add gold to hit min value
                            if (minChestValue - currentValue > 0)
                            {
                                gold = minChestValue - currentValue;
                            }
                            return;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// adds item to chest if chest has enough space
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private bool TryAddItem(GameItem itemToAdd, int chestSize)
        {
            //check if item too big
            if (contentsTotalSize + itemToAdd.ItemSize > chestSize)
            {
                return false;//no space dont add it
            }
            contentsTotalSize += itemToAdd.ItemSize;
            foreach (GameItem itemInChest in items)
            {
                if (itemInChest.Name == itemToAdd.Name)
                {
                    itemInChest.Quantity += itemToAdd.Quantity;
                    return true;
                }
            }

            items.Add(new GameItem { 
                Name = itemToAdd.Name,
                Quantity = itemToAdd.Quantity,
                GoldValue = itemToAdd.GoldValue,
                ItemSize = itemToAdd.ItemSize
            });
            return true;
        }

        public Random Seed { get; }
    }

    public class GameItem
    {
        public required string Name { get; set; }
        public int GoldValue { get; set; }

        public int Quantity { get; set; }

        public int ItemSize { get; set; }
    }
}
