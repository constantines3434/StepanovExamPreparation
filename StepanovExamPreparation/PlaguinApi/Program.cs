using PlaguinApi;
using System;
using System.Collections.Generic;
using System.Reflection;
class Program
{
    static void Main()
    {
        List<IPlugin> plugins = LoadPlugins();

        foreach (var plugin in plugins)
        {
            plugin.Execute();
        }
    }

    static List<IPlugin> LoadPlugins()
    {
        List<IPlugin> plugins = new List<IPlugin>();
        // Создайте экземпляры плагинов и добавьте их в список.
        plugins.Add(new Plugin());
        return plugins;
    }
}
