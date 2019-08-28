using System.Collections.Generic;

namespace LeetCode.Easy
{
    public class FirstBadVersion
    {
        IVersionControl _versionControl;

        public FirstBadVersion(IVersionControl versionControl)
        {
            _versionControl = versionControl;
        }

        public int GetFirstBadVersion(int n)
        {
            var versions = new Dictionary<int, bool>();
            double min = 1;
            double max = n;

            while (min != max)
            {
                int version = (int)(max / 2 + min / 2);

                if (!versions.ContainsKey(version)) versions.Add(version, _versionControl.IsBadVersion(version));

                if (max == version || min == version) return versions[version] ? version : version + 1;

                max = versions[version] ? version : max;
                min = !versions[version] ? version : min;
            }

            return (int)max;
        }
    }

    public interface IVersionControl
    {
        bool IsBadVersion(int version);
    }
}