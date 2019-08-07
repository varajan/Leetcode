using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    public class Car_Fleet
    {
        public int CarFleet(int target, int[] position, int[] speed)
        {
            int result = 0;

            var cars = speed
                .Select((x, i) => (position: position[i], speed: speed[i]))
                .OrderByDescending(car => car.position).ToList();

            while (cars.Any())
            {
                cars = cars.Select(car => (position: car.position + car.speed, car.speed)).ToList();

                var previous = cars.First();
                var fleet = new List<(int position, int speed)> { previous };

                for (var i = 1; i < cars.Count; i++)
                {
                    if (AreSmashed(cars[i], previous)) continue;

                    fleet.Add(cars[i]);
                    previous = cars[i];
                }

                result += fleet.Count(car => car.position >= target);

                cars = fleet.Where(car => car.position < target).ToList();

            }

            return result;

            bool AreSmashed((int position, int speed) current, (int position, int speed) previous) =>
                previous.position <= current.position && ArrivalTime(previous) <= ArrivalTime(current);

            double ArrivalTime((int position, int speed) car) => ((double)car.position - target) / car.speed;
        }
    }
}