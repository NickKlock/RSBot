﻿using System;
using System.IO;

namespace RSBot.Helper
{
    internal static class ProfilePathHelper
    {
        public static string GetProfileConfigFileName()
        {
            return Path.Combine(Environment.CurrentDirectory, "Data", "User", "Profiles.rs");
        }

        public static string GetProfileFile(string profileName)
        {
            return Path.Combine(Environment.CurrentDirectory, "Data", "User", $"{profileName}.rs");
        }

        public static string GetProfileDirectory(string profileName)
        {
            return Path.Combine(Environment.CurrentDirectory, "Data", "User", profileName);
        }
    }
}