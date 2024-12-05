/*
 * Name: Kaci Craycraft
 * South Hills Username: kcraycraft45
 */
//DO NOT USE LINQ!

namespace IT230_Arrays1
{
    public class Source
    {
        public static int[] players; 
        
        public static void InsertIntoArray(int number)
        {
            Grow();
            players[^1] = number;
        }
        public static void Grow()
        {
            if(players != null)
            {
				int[] temp = new int[players.Length + 1];//CRASH

				for (int i = 0; i < players.Length; i++)
				{
					temp[i] = players[i];
				}
				players = temp;
			}
            else
            {
                int[] temp = new int[1];
                players = temp;
            }
		}
		public static bool SearchArray(int number)
        {
            
            for(int i = 0; i < players.Length; i++)
            {
                if (players[i] == number) return true;
            }
            return false;
        }
        public static int FindElement(int number)
        {
			for (int i = 0; i < players.Length; i++)
			{
				if (players[i] == number) return i;
			}
			return -1;
		}
        public static void DeleteFromArray(int number)
        {
            int indexer = FindElement(number);
            if (indexer != -1)
            {
                for (int i = indexer; i < players.Length - 1; i++)
                {
                    players[i] = players[i + 1];
                }
                ShrinkTheArray();
            }
        }
        public static void ShrinkTheArray()
        {
			int[] temp = new int[players.Length - 1];
			for (int i = 0; i < temp.Length; i++)
			{
				temp[i] = players[i];
			}
			players = temp;
		}
    }
}