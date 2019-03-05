using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    public static class KeysAndRooms
    {
        public static bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var visited = new bool[rooms.Count].ToList();
            if (rooms.Count > 1 && !rooms.First().Any()) return false;

            VisitRoom(0, rooms, ref visited);

            return visited.All(x => x);
        }

        private static void VisitRoom(int room, IList<IList<int>> rooms, ref List<bool> visited)
        {
            visited[room] = true;
            if (visited.All(x => x)) return;

            var keys = rooms[room];
            foreach (var key in keys)
            {
                if (!visited[key]) VisitRoom(key, rooms, ref visited);
                visited[key] = true;
            }
        }
    }
}