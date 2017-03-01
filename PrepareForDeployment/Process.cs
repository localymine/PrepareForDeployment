using System;

internal static IEnumerable<string> ReadLines(this string s)
{
    string line;
    using (var sr = new StringReader(s))
        while ((line = sr.ReadLine()) != null)
            yield return line;
}
