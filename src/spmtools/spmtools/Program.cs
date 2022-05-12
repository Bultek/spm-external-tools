using IWshRuntimeLibrary;
using System.Diagnostics;
using System.IO;
public class tools
{
    public static void Main(string[] args)
    {
        CreateShortcut(args[1], args[2], args[3]);
    }
    public static void CreateShortcut(string executable, string package, string icon = @"C:\SPM\icon.ico")
    {
        // Create a shortcut to Start Menu
        string shortcutPath = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\" + package + ".lnk";
        WshShell shell = new WshShell();
        IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
        shortcut.TargetPath = executable;
        shortcut.WorkingDirectory = @"C:\SPM-APPS\" + package;
        shortcut.IconLocation = icon;

        shortcut.Save();
        Debug.WriteLine("Shortcut created!");
        // Thanks Copilot
    }
}
