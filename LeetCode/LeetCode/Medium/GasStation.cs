namespace LeetCode.Medium
{
    public class GasStation
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            var count = gas.Length;

            for (int i = 0; i < count; i++)
            {
                var tank = 0;

                for (int j = i; j < count + i; j++)
                {
                    var index = j < count ? j : j - count;

                    tank += gas[index] - cost[index];
                    if (tank < 0) break;
                }

                if (tank >= 0) return i;
            }

            return -1;
        }
    }
}