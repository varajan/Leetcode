using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    public static class KeysAndRooms
    {
        public static bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var visited = new bool[rooms.Count].ToList();

            VisitRoom(0, ref rooms, ref visited);

            return visited.All(x => x);
        }

        private static void VisitRoom(int room, ref IList<IList<int>> rooms, ref List<bool> visited)
        {
            visited[room] = true;
            if (visited.All(x => x)) return;

            var keys = rooms[room];
            foreach (var key in keys)
            {
                if (!visited[key]) VisitRoom(key, ref rooms, ref visited);
            }
        }
    }
}