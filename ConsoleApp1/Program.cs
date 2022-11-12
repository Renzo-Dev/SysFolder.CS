using System;

namespace MyProject
{
    public static class SysFolder
    {
        public static string C = Environment.ExpandEnvironmentVariables("%systemdrive%");
        public static string Temp = Environment.ExpandEnvironmentVariables("%temp%");
        public static string UserProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public static string Local = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local";
        public static string Roaming = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Roaming";
        public static string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string Windows = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
        public static string System32 = Environment.GetFolderPath(Environment.SpecialFolder.System);
        public static string SysWOW64 = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
        public static string ProgramFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        public static string ProgramFilesX86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
        public static string ProgramData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
    }
}